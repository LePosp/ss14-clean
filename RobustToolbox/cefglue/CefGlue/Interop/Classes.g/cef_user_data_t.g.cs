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
    internal unsafe struct cef_user_data_t
    {
        internal cef_base_ref_counted_t _base;
        
        internal GCHandle _obj;
        
        [UnmanagedCallersOnly]
        public static void add_ref(cef_user_data_t* self)
        {
            var obj = (CefUserData)self->_obj.Target;
            obj.add_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int release(cef_user_data_t* self)
        {
            var obj = (CefUserData)self->_obj.Target;
            return obj.release(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_one_ref(cef_user_data_t* self)
        {
            var obj = (CefUserData)self->_obj.Target;
            return obj.has_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_at_least_one_ref(cef_user_data_t* self)
        {
            var obj = (CefUserData)self->_obj.Target;
            return obj.has_at_least_one_ref(self);
        }
        
        internal static cef_user_data_t* Alloc()
        {
            var ptr = (cef_user_data_t*)NativeMemory.Alloc((UIntPtr)sizeof(cef_user_data_t));
            *ptr = default(cef_user_data_t);
            ptr->_base._size = (UIntPtr)sizeof(cef_user_data_t);
            ptr->_base._add_ref = (delegate* unmanaged<cef_base_ref_counted_t*, void>)(delegate* unmanaged<cef_user_data_t*, void>)&add_ref;
            ptr->_base._release = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_user_data_t*, int>)&release;
            ptr->_base._has_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_user_data_t*, int>)&has_one_ref;
            ptr->_base._has_at_least_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_user_data_t*, int>)&has_at_least_one_ref;
            return ptr;
        }
        
        internal static void Free(cef_user_data_t* ptr)
        {
            NativeMemory.Free((void*)ptr);
        }
        
    }
}
