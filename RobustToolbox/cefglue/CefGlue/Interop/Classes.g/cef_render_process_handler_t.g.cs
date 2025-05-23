﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_render_process_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_render_process_handler_t*, void> _on_web_kit_initialized;
        internal delegate* unmanaged<cef_render_process_handler_t*, cef_browser_t*, cef_dictionary_value_t*, void> _on_browser_created;
        internal delegate* unmanaged<cef_render_process_handler_t*, cef_browser_t*, void> _on_browser_destroyed;
        internal delegate* unmanaged<cef_render_process_handler_t*, cef_load_handler_t*> _get_load_handler;
        internal delegate* unmanaged<cef_render_process_handler_t*, cef_browser_t*, cef_frame_t*, cef_v8context_t*, void> _on_context_created;
        internal delegate* unmanaged<cef_render_process_handler_t*, cef_browser_t*, cef_frame_t*, cef_v8context_t*, void> _on_context_released;
        internal delegate* unmanaged<cef_render_process_handler_t*, cef_browser_t*, cef_frame_t*, cef_v8context_t*, cef_v8exception_t*, cef_v8stack_trace_t*, void> _on_uncaught_exception;
        internal delegate* unmanaged<cef_render_process_handler_t*, cef_browser_t*, cef_frame_t*, cef_domnode_t*, void> _on_focused_node_changed;
        internal delegate* unmanaged<cef_render_process_handler_t*, cef_browser_t*, cef_frame_t*, CefProcessId, cef_process_message_t*, int> _on_process_message_received;
        
        internal GCHandle _obj;
        
        [UnmanagedCallersOnly]
        public static void add_ref(cef_render_process_handler_t* self)
        {
            var obj = (CefRenderProcessHandler)self->_obj.Target;
            obj.add_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int release(cef_render_process_handler_t* self)
        {
            var obj = (CefRenderProcessHandler)self->_obj.Target;
            return obj.release(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_one_ref(cef_render_process_handler_t* self)
        {
            var obj = (CefRenderProcessHandler)self->_obj.Target;
            return obj.has_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_at_least_one_ref(cef_render_process_handler_t* self)
        {
            var obj = (CefRenderProcessHandler)self->_obj.Target;
            return obj.has_at_least_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static void on_web_kit_initialized(cef_render_process_handler_t* self)
        {
            var obj = (CefRenderProcessHandler)self->_obj.Target;
            obj.on_web_kit_initialized(self);
        }
        
        [UnmanagedCallersOnly]
        public static void on_browser_created(cef_render_process_handler_t* self, cef_browser_t* browser, cef_dictionary_value_t* extra_info)
        {
            var obj = (CefRenderProcessHandler)self->_obj.Target;
            obj.on_browser_created(self, browser, extra_info);
        }
        
        [UnmanagedCallersOnly]
        public static void on_browser_destroyed(cef_render_process_handler_t* self, cef_browser_t* browser)
        {
            var obj = (CefRenderProcessHandler)self->_obj.Target;
            obj.on_browser_destroyed(self, browser);
        }
        
        [UnmanagedCallersOnly]
        public static cef_load_handler_t* get_load_handler(cef_render_process_handler_t* self)
        {
            var obj = (CefRenderProcessHandler)self->_obj.Target;
            return obj.get_load_handler(self);
        }
        
        [UnmanagedCallersOnly]
        public static void on_context_created(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context)
        {
            var obj = (CefRenderProcessHandler)self->_obj.Target;
            obj.on_context_created(self, browser, frame, context);
        }
        
        [UnmanagedCallersOnly]
        public static void on_context_released(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context)
        {
            var obj = (CefRenderProcessHandler)self->_obj.Target;
            obj.on_context_released(self, browser, frame, context);
        }
        
        [UnmanagedCallersOnly]
        public static void on_uncaught_exception(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_v8context_t* context, cef_v8exception_t* exception, cef_v8stack_trace_t* stackTrace)
        {
            var obj = (CefRenderProcessHandler)self->_obj.Target;
            obj.on_uncaught_exception(self, browser, frame, context, exception, stackTrace);
        }
        
        [UnmanagedCallersOnly]
        public static void on_focused_node_changed(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_domnode_t* node)
        {
            var obj = (CefRenderProcessHandler)self->_obj.Target;
            obj.on_focused_node_changed(self, browser, frame, node);
        }
        
        [UnmanagedCallersOnly]
        public static int on_process_message_received(cef_render_process_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, CefProcessId source_process, cef_process_message_t* message)
        {
            var obj = (CefRenderProcessHandler)self->_obj.Target;
            return obj.on_process_message_received(self, browser, frame, source_process, message);
        }
        
        internal static cef_render_process_handler_t* Alloc()
        {
            var ptr = (cef_render_process_handler_t*)NativeMemory.Alloc((UIntPtr)sizeof(cef_render_process_handler_t));
            *ptr = default(cef_render_process_handler_t);
            ptr->_base._size = (UIntPtr)sizeof(cef_render_process_handler_t);
            ptr->_base._add_ref = (delegate* unmanaged<cef_base_ref_counted_t*, void>)(delegate* unmanaged<cef_render_process_handler_t*, void>)&add_ref;
            ptr->_base._release = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_render_process_handler_t*, int>)&release;
            ptr->_base._has_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_render_process_handler_t*, int>)&has_one_ref;
            ptr->_base._has_at_least_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_render_process_handler_t*, int>)&has_at_least_one_ref;
            ptr->_on_web_kit_initialized = &on_web_kit_initialized;
            ptr->_on_browser_created = &on_browser_created;
            ptr->_on_browser_destroyed = &on_browser_destroyed;
            ptr->_get_load_handler = &get_load_handler;
            ptr->_on_context_created = &on_context_created;
            ptr->_on_context_released = &on_context_released;
            ptr->_on_uncaught_exception = &on_uncaught_exception;
            ptr->_on_focused_node_changed = &on_focused_node_changed;
            ptr->_on_process_message_received = &on_process_message_received;
            return ptr;
        }
        
        internal static void Free(cef_render_process_handler_t* ptr)
        {
            NativeMemory.Free((void*)ptr);
        }
        
    }
}
