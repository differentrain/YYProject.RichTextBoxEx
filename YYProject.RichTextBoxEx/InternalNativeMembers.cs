﻿using System;
using System.Runtime.InteropServices;

namespace YYProject.RichEdit
{
    internal class NativeMember
    {

        #region Native api
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IntPtr LoadLibrary(String path);
        [DllImport("user32", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(HandleRef hWnd, Int32 msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(HandleRef hWnd, Int32 msg, IntPtr wParam, ref PARAFORMAT2 lParam);
        #endregion

        #region consts

        public const Int32 ECOOP_OR = 0x0002,
                            ECOOP_AND = 0x0003,
                            RTB_HORIZ = 0x0001,
                            RTB_VERT = 0x0002,
                            RTB_FORCE = 0x0010,
                            EM_GETPARAFORMAT = 0x0400 + 61,
                            EM_SETPARAFORMAT = 0x0400 + 71,
                            EM_SETOPTIONS = 0x0400 + 77,
                            PFM_SPACEBEFORE = 0x00000040,
                            PFM_SPACEAFTER = 0x00000080,
                            PFM_LINESPACING = 0x00000100,
                            ES_DISABLENOSCROLL = 0x00002000,
                            ES_VERTICAL = 0x00400000,//vertical writing: https://msdn.microsoft.com/en-us/library/windows/desktop/bb774367(v=vs.85).aspx#ES_VERTICAL
                            WS_VSCROLL = 0x00200000,
                            WS_HSCROLL = 0x00100000,
                            WS_BORDER = 0x00800000,
                            WS_EX_CLIENTEDGE = 0x00000200,
                            WM_SETFOCUS = 0x7,
                            WM_LBUTTONDOWN = 0x201,
                            WM_LBUTTONUP = 0x202,
                            WM_LBUTTONDBLCLK = 0x203,
                            WM_RBUTTONDOWN = 0x204,
                            WM_RBUTTONUP = 0x205,
                            WM_RBUTTONDBLCLK = 0x206,
                            WM_KEYDOWN = 0x0100,
                            WM_KEYUP = 0x0101;

        #endregion




    }

    // https://msdn.microsoft.com/en-us/library/windows/desktop/bb787942(v=vs.85).aspx
    [StructLayout(LayoutKind.Sequential)]
    internal struct PARAFORMAT2
    {
        public Int32 cbSize;
        public UInt32 dwMask;
        public Int16 wNumbering;
        public Int16 wReserved;
        public Int32 dxStartIndent;
        public Int32 dxRightIndent;
        public Int32 dxOffset;
        public Int16 wAlignment;
        public Int16 cTabCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public Int32[] rgxTabs;
        public Int32 dySpaceBefore;
        public Int32 dySpaceAfter;
        public Int32 dyLineSpacing;
        public Int16 sStyle;
        public Byte bLineSpacingRule;
        public Byte bOutlineLevel;
        public Int16 wShadingWeight;
        public Int16 wShadingStyle;
        public Int16 wNumberingStart;
        public Int16 wNumberingStyle;
        public Int16 wNumberingTab;
        public Int16 wBorderSpace;
        public Int16 wBorderWidth;
        public Int16 wBorders;
    }



}
