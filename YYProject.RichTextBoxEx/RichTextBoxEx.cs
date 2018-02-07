using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

//因为这个库会可能会单独发，所以就用英文写注释了……
namespace YYProject.RichEdit
{
    /// <summary>
    /// Provides a more comprehensive RichTextBox.
    /// <para>Features：vertical writing、paragraph spacing、line spacing、additional option of <see cref="ReadOnly"/>.</para>
    /// </summary>
    public class RichTextBoxEx : RichTextBox
    {
        /* The crux of vertical writing is the overrides of CreateParams method in RichTextBox class, 
         * to load a later richedit version. 
         * Some code was copied form http://referencesource.microsoft.com/#System.Windows.Forms/winforms/Managed/System/WinForms/RichTextBox.cs */


        private static IntPtr moduleHandle = IntPtr.Zero;

        //http://referencesource.microsoft.com/#System.Windows.Forms/winforms/Managed/System/WinForms/RichTextBox.cs,d2aebb12b70acde0
        /// <summary>
        /// Gets the required creation parameters when the control handle is created.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                if (moduleHandle == IntPtr.Zero)
                {
                    moduleHandle = NativeMember.LoadLibrary("msftedit.dll");
                    // This code has been here since the inception of the project, 
                    // we can’t determine why we have to compare w/ 32 here.
                    // This fails on 3-GB mode, (once the dll is loaded above 3GB memory space) (see Dev10 bug#732388)
                    // The original annotation above is so gooooooooood....
                    // 这个东西原注释也是碉堡了……
                    if ((UInt64)moduleHandle < 32)
                    {
                        throw new Win32Exception(Marshal.GetLastWin32Error(), "Failed to load msftedit.dll.");
                    }
                }
                var cp = base.CreateParams;
                cp.ClassName = "RICHEDIT50W";//  richedit 4.1

                // vertical writing
                if (VerticalWriting)
                {
                    cp.Style |= NativeMember.ES_VERTICAL;
                }

                if (Multiline)
                {
                    if (((Int32)ScrollBars & NativeMember.RTB_HORIZ) != 0 && !WordWrap)
                    {
                        // original annotation:
                        // RichEd infers word wrap from the absence of horizontal scroll bars
                        cp.Style |= NativeMember.WS_HSCROLL;
                        if (((Int32)ScrollBars & NativeMember.RTB_FORCE) != 0)
                            cp.Style |= NativeMember.ES_DISABLENOSCROLL;
                    }
                    if (((Int32)ScrollBars & NativeMember.RTB_VERT) != 0)
                    {
                        cp.Style |= NativeMember.WS_VSCROLL;
                        if (((Int32)ScrollBars & NativeMember.RTB_FORCE) != 0)
                            cp.Style |= NativeMember.ES_DISABLENOSCROLL;
                    }
                }
                // original annotation:
                // VSWhidbey 94843: Remove the WS_BORDER style from the control, if we're trying to set it,
                // to prevent the control from displaying the single point rectangle around the 3D border
                if (BorderStyle.FixedSingle == BorderStyle && ((cp.Style & NativeMember.WS_BORDER) != 0))
                {
                    cp.Style &= (~NativeMember.WS_BORDER);
                    cp.ExStyle |= NativeMember.WS_EX_CLIENTEDGE;
                }

                return cp;
            }
        }
        /// <summary>
        /// Processes Windows messages.
        /// </summary>
        /// <param name="m">A Windows Message object.</param>
        protected override void WndProc(ref Message m)
        {
            //RTBex can't be "operated" when RTBReadOnlyMode.ViewOnly .
            if (_ReadOnly == RTBReadOnlyMode.ViewOnly && (m.Msg == NativeMember.WM_SETFOCUS || m.Msg == NativeMember.WM_KEYDOWN || m.Msg == NativeMember.WM_KEYUP || m.Msg == NativeMember.WM_LBUTTONDOWN || m.Msg == NativeMember.WM_LBUTTONUP || m.Msg == NativeMember.WM_LBUTTONDBLCLK || m.Msg == NativeMember.WM_RBUTTONDOWN || m.Msg == NativeMember.WM_RBUTTONUP || m.Msg == NativeMember.WM_RBUTTONDBLCLK))
            {
                return;
            }
            base.WndProc(ref m);
        }


        #region properties  

        private Boolean _VerticalWriting = false;
        private RTBReadOnlyMode _ReadOnly = RTBReadOnlyMode.Not;
 
        /// <summary>
        /// Gets or sets a value indicating whether text in the text box is written vertically.
        /// </summary>
        [Browsable(true), DefaultValue(false), Category("VerticalWriting"), Description("Controls weather the text in the text box is written vertically.")]
        public Boolean VerticalWriting
        {
            get => _VerticalWriting;
            set
            {
                if (value != _VerticalWriting)
                {
                    _VerticalWriting = value;
                    if (IsHandleCreated)
                    {
                        NativeMember.SendMessage(new HandleRef(this, Handle), NativeMember.EM_SETOPTIONS, (IntPtr)(_VerticalWriting ? NativeMember.ECOOP_OR : NativeMember.ECOOP_AND), (IntPtr)(_VerticalWriting ? NativeMember.ES_VERTICAL : ~NativeMember.ES_VERTICAL));
                    }
                    OnVerticalWritingChanged(EventArgs.Empty);
                }

            }
        }

        /// <summary>
        /// Gets or sets a value indicating the read-only mode of the text in the text box.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">The value of ReadOnly property is invalid.</exception>
        [Browsable(true), DefaultValue(RTBReadOnlyMode.Not), Category("ReadOnly"), Description("Indicates the read-only mode of the text in the text box.")]
        public new RTBReadOnlyMode ReadOnly
        {
            get => _ReadOnly;
            set
            {
                if (value < RTBReadOnlyMode.Not || value > RTBReadOnlyMode.ViewOnly)
                {
                    throw new ArgumentOutOfRangeException("The value of ReadOnly property is invalid.");
                }
                if (value != _ReadOnly)
                {
                    _ReadOnly = value;
                    base.ReadOnly = value != RTBReadOnlyMode.Not;
                    OnReadOnlyChanged(EventArgs.Empty);
                }

            }
        }

        /// <summary>
        /// Gets or sets the paragraph spacing of the current text selection or insertion point.
        /// </summary>
        [Browsable(false)]
        public RTBParaSpacing SelectionParaSpacing
        {
            get
            {
                ForceHandleCreate();
                var pF = new PARAFORMAT2
                {
                    cbSize = 188,
                    dwMask = NativeMember.PFM_SPACEBEFORE | NativeMember.PFM_SPACEAFTER,
                };
                NativeMember.SendMessage(new HandleRef(this, Handle), NativeMember.EM_GETPARAFORMAT, IntPtr.Zero, ref pF);
                return new RTBParaSpacing(pF.dySpaceBefore, pF.dySpaceAfter);
            }
            set
            {
                ForceHandleCreate();
                var pF = new PARAFORMAT2
                {
                    cbSize = 188,
                    dwMask = NativeMember.PFM_SPACEBEFORE | NativeMember.PFM_SPACEAFTER,
                    dySpaceBefore = value.Before,
                    dySpaceAfter = value.After
                };
                NativeMember.SendMessage(new HandleRef(this, Handle), NativeMember.EM_SETPARAFORMAT, IntPtr.Zero, ref pF);
            }
        }

        /// <summary>
        /// Gets or sets the line spacing of the current text selection or insertion point.
        /// </summary>
        [Browsable(false)]
        public RTBLineSpacing SelectionLineSpacing
        {
            get
            {
                ForceHandleCreate();
                var pF = new PARAFORMAT2
                {
                    cbSize = 188,
                    dwMask = NativeMember.PFM_LINESPACING,
                };
                NativeMember.SendMessage(new HandleRef(this, Handle), NativeMember.EM_GETPARAFORMAT, IntPtr.Zero, ref pF);
                return new RTBLineSpacing(pF.dyLineSpacing, (RTBLineSpacingRule)pF.bLineSpacingRule);
            }
            set
            {
                ForceHandleCreate();
                var pF = new PARAFORMAT2
                {
                    cbSize = 188,
                    dwMask = NativeMember.PFM_LINESPACING,
                    dyLineSpacing = value.Spacing,
                    bLineSpacingRule = (Byte)value.Rule
                };
                NativeMember.SendMessage(new HandleRef(this, Handle), NativeMember.EM_SETPARAFORMAT, IntPtr.Zero, ref pF);
            }
        }
        #endregion

        #region methods

        //http://referencesource.microsoft.com/#System.Windows.Forms/winforms/Managed/System/WinForms/RichTextBox.cs,f4b759c0e712ef89
        private void ForceHandleCreate()
        {
            if (!IsHandleCreated)
            {
                CreateHandle();
            }
        }

        /// <summary>
        /// Raise the <see cref="RichTextBoxEx.VerticalWritingChanged"/> event.
        /// </summary>
        /// <param name="e">Event data.</param>
        protected virtual void OnVerticalWritingChanged(EventArgs e) => VerticalWritingChanged?.Invoke(this, e);
        /// <summary>
        /// Raise the <see cref="RichTextBoxEx.ReadOnlyChanged"/> event.
        /// </summary>
        /// <param name="e">Event data.</param>
        protected override void OnReadOnlyChanged(EventArgs e) => ReadOnlyChanged?.Invoke(this, e);
    

        #endregion

        #region events
        /// <summary>
        /// Occurs when the value of <see cref="RichTextBoxEx.VerticalWriting"/> property has changed.
        /// </summary>
        [Browsable(true), Category("VerticalWritingChanged"), Description(" Occurs when VerticalWriting property value is changed.")]
        public event EventHandler VerticalWritingChanged;
        /// <summary>
        /// Occurs when the value of <see cref="RichTextBoxEx.ReadOnly"/> property has changed.
        /// </summary>
        [Browsable(true), Category("ReadOnlyChanged"), Description(" Occurs when ReadOnly property value is changed.")]
        public new event EventHandler ReadOnlyChanged;
        #endregion
    }
}
