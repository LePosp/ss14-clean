﻿//
// This file manually written from cef/include/internal/cef_types.h.
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    internal unsafe struct cef_pdf_print_settings_t
    {
        public int landscape;
        public int print_background;
        public double scale;
        public double paper_width;
        public double paper_height;
        public int prefer_css_page_size;
        public CefPdfPrintMarginType margin_type;
        public double margin_top;
        public double margin_right;
        public double margin_bottom;
        public double margin_left;
        public cef_string_t page_ranges;
        public int display_header_footer;
        public cef_string_t header_template;
        public cef_string_t footer_template;
        public int generate_tagged_pdf;
        public int generate_document_outline;

        internal static void Clear(cef_pdf_print_settings_t* ptr)
        {
            libcef.string_clear(&ptr->page_ranges);
            libcef.string_clear(&ptr->header_template);
            libcef.string_clear(&ptr->footer_template);
        }

        #region Alloc & Free
        public static cef_pdf_print_settings_t* Alloc()
        {
            var ptr = (cef_pdf_print_settings_t*)NativeMemory.AllocZeroed((UIntPtr)sizeof(cef_pdf_print_settings_t));
            return ptr;
        }

        public static void Free(cef_pdf_print_settings_t* ptr)
        {
            NativeMemory.Free(ptr);
        }
        #endregion
    }
}
