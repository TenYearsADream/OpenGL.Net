
// MIT License
// 
// Copyright (c) 2009-2017 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// 
// This file is automatically generated

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

using Khronos;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// [GL] glVertexAttribL1i64NV: Binding for glVertexAttribL1i64NV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL1NV(UInt32 index, Int64 x)
		{
			Debug.Assert(Delegates.pglVertexAttribL1i64NV != null, "pglVertexAttribL1i64NV not implemented");
			Delegates.pglVertexAttribL1i64NV(index, x);
			LogCommand("glVertexAttribL1i64NV", null, index, x			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexAttribL2i64NV: Binding for glVertexAttribL2i64NV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL2NV(UInt32 index, Int64 x, Int64 y)
		{
			Debug.Assert(Delegates.pglVertexAttribL2i64NV != null, "pglVertexAttribL2i64NV not implemented");
			Delegates.pglVertexAttribL2i64NV(index, x, y);
			LogCommand("glVertexAttribL2i64NV", null, index, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexAttribL3i64NV: Binding for glVertexAttribL3i64NV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL3NV(UInt32 index, Int64 x, Int64 y, Int64 z)
		{
			Debug.Assert(Delegates.pglVertexAttribL3i64NV != null, "pglVertexAttribL3i64NV not implemented");
			Delegates.pglVertexAttribL3i64NV(index, x, y, z);
			LogCommand("glVertexAttribL3i64NV", null, index, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexAttribL4i64NV: Binding for glVertexAttribL4i64NV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int64"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL4NV(UInt32 index, Int64 x, Int64 y, Int64 z, Int64 w)
		{
			Debug.Assert(Delegates.pglVertexAttribL4i64NV != null, "pglVertexAttribL4i64NV not implemented");
			Delegates.pglVertexAttribL4i64NV(index, x, y, z, w);
			LogCommand("glVertexAttribL4i64NV", null, index, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexAttribL1i64vNV: Binding for glVertexAttribL1i64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL1NV(UInt32 index, Int64[] v)
		{
			Debug.Assert(v.Length >= 1);
			unsafe {
				fixed (Int64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL1i64vNV != null, "pglVertexAttribL1i64vNV not implemented");
					Delegates.pglVertexAttribL1i64vNV(index, p_v);
					LogCommand("glVertexAttribL1i64vNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexAttribL2i64vNV: Binding for glVertexAttribL2i64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL2NV(UInt32 index, Int64[] v)
		{
			Debug.Assert(v.Length >= 2);
			unsafe {
				fixed (Int64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL2i64vNV != null, "pglVertexAttribL2i64vNV not implemented");
					Delegates.pglVertexAttribL2i64vNV(index, p_v);
					LogCommand("glVertexAttribL2i64vNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexAttribL3i64vNV: Binding for glVertexAttribL3i64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL3NV(UInt32 index, Int64[] v)
		{
			Debug.Assert(v.Length >= 3);
			unsafe {
				fixed (Int64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL3i64vNV != null, "pglVertexAttribL3i64vNV not implemented");
					Delegates.pglVertexAttribL3i64vNV(index, p_v);
					LogCommand("glVertexAttribL3i64vNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexAttribL4i64vNV: Binding for glVertexAttribL4i64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL4NV(UInt32 index, Int64[] v)
		{
			Debug.Assert(v.Length >= 4);
			unsafe {
				fixed (Int64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL4i64vNV != null, "pglVertexAttribL4i64vNV not implemented");
					Delegates.pglVertexAttribL4i64vNV(index, p_v);
					LogCommand("glVertexAttribL4i64vNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexAttribL1ui64NV: Binding for glVertexAttribL1ui64NV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL1NV(UInt32 index, UInt64 x)
		{
			Debug.Assert(Delegates.pglVertexAttribL1ui64NV != null, "pglVertexAttribL1ui64NV not implemented");
			Delegates.pglVertexAttribL1ui64NV(index, x);
			LogCommand("glVertexAttribL1ui64NV", null, index, x			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexAttribL2ui64NV: Binding for glVertexAttribL2ui64NV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL2NV(UInt32 index, UInt64 x, UInt64 y)
		{
			Debug.Assert(Delegates.pglVertexAttribL2ui64NV != null, "pglVertexAttribL2ui64NV not implemented");
			Delegates.pglVertexAttribL2ui64NV(index, x, y);
			LogCommand("glVertexAttribL2ui64NV", null, index, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexAttribL3ui64NV: Binding for glVertexAttribL3ui64NV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL3NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z)
		{
			Debug.Assert(Delegates.pglVertexAttribL3ui64NV != null, "pglVertexAttribL3ui64NV not implemented");
			Delegates.pglVertexAttribL3ui64NV(index, x, y, z);
			LogCommand("glVertexAttribL3ui64NV", null, index, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexAttribL4ui64NV: Binding for glVertexAttribL4ui64NV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:UInt64"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL4NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z, UInt64 w)
		{
			Debug.Assert(Delegates.pglVertexAttribL4ui64NV != null, "pglVertexAttribL4ui64NV not implemented");
			Delegates.pglVertexAttribL4ui64NV(index, x, y, z, w);
			LogCommand("glVertexAttribL4ui64NV", null, index, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexAttribL1ui64vNV: Binding for glVertexAttribL1ui64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL1NV(UInt32 index, UInt64[] v)
		{
			Debug.Assert(v.Length >= 1);
			unsafe {
				fixed (UInt64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL1ui64vNV != null, "pglVertexAttribL1ui64vNV not implemented");
					Delegates.pglVertexAttribL1ui64vNV(index, p_v);
					LogCommand("glVertexAttribL1ui64vNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexAttribL2ui64vNV: Binding for glVertexAttribL2ui64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL2NV(UInt32 index, UInt64[] v)
		{
			Debug.Assert(v.Length >= 2);
			unsafe {
				fixed (UInt64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL2ui64vNV != null, "pglVertexAttribL2ui64vNV not implemented");
					Delegates.pglVertexAttribL2ui64vNV(index, p_v);
					LogCommand("glVertexAttribL2ui64vNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexAttribL3ui64vNV: Binding for glVertexAttribL3ui64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL3NV(UInt32 index, UInt64[] v)
		{
			Debug.Assert(v.Length >= 3);
			unsafe {
				fixed (UInt64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL3ui64vNV != null, "pglVertexAttribL3ui64vNV not implemented");
					Delegates.pglVertexAttribL3ui64vNV(index, p_v);
					LogCommand("glVertexAttribL3ui64vNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexAttribL4ui64vNV: Binding for glVertexAttribL4ui64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="v">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribL4NV(UInt32 index, UInt64[] v)
		{
			Debug.Assert(v.Length >= 4);
			unsafe {
				fixed (UInt64* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribL4ui64vNV != null, "pglVertexAttribL4ui64vNV not implemented");
					Delegates.pglVertexAttribL4ui64vNV(index, p_v);
					LogCommand("glVertexAttribL4ui64vNV", null, index, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetVertexAttribLi64vNV: Binding for glGetVertexAttribLi64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:VertexAttribEnum"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void GetVertexAttribLNV(UInt32 index, VertexAttribEnum pname, [Out] Int64[] @params)
		{
			unsafe {
				fixed (Int64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribLi64vNV != null, "pglGetVertexAttribLi64vNV not implemented");
					Delegates.pglGetVertexAttribLi64vNV(index, (Int32)pname, p_params);
					LogCommand("glGetVertexAttribLi64vNV", null, index, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glGetVertexAttribLui64vNV: Binding for glGetVertexAttribLui64vNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:VertexAttribEnum"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt64[]"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void GetVertexAttribLNV(UInt32 index, VertexAttribEnum pname, [Out] UInt64[] @params)
		{
			unsafe {
				fixed (UInt64* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribLui64vNV != null, "pglGetVertexAttribLui64vNV not implemented");
					Delegates.pglGetVertexAttribLui64vNV(index, (Int32)pname, p_params);
					LogCommand("glGetVertexAttribLui64vNV", null, index, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// [GL] glVertexAttribLFormatNV: Binding for glVertexAttribLFormatNV.
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="size">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="type">
		/// A <see cref="T:VertexAttribType"/>.
		/// </param>
		/// <param name="stride">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
		public static void VertexAttribLFormatNV(UInt32 index, Int32 size, VertexAttribType type, Int32 stride)
		{
			Debug.Assert(Delegates.pglVertexAttribLFormatNV != null, "pglVertexAttribLFormatNV not implemented");
			Delegates.pglVertexAttribLFormatNV(index, size, (Int32)type, stride);
			LogCommand("glVertexAttribLFormatNV", null, index, size, type, stride			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL1i64NV(UInt32 index, Int64 x);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL1i64NV pglVertexAttribL1i64NV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL2i64NV(UInt32 index, Int64 x, Int64 y);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL2i64NV pglVertexAttribL2i64NV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL3i64NV(UInt32 index, Int64 x, Int64 y, Int64 z);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL3i64NV pglVertexAttribL3i64NV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL4i64NV(UInt32 index, Int64 x, Int64 y, Int64 z, Int64 w);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL4i64NV pglVertexAttribL4i64NV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL1i64vNV(UInt32 index, Int64* v);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL1i64vNV pglVertexAttribL1i64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL2i64vNV(UInt32 index, Int64* v);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL2i64vNV pglVertexAttribL2i64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL3i64vNV(UInt32 index, Int64* v);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL3i64vNV pglVertexAttribL3i64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL4i64vNV(UInt32 index, Int64* v);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL4i64vNV pglVertexAttribL4i64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL1ui64NV(UInt32 index, UInt64 x);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL1ui64NV pglVertexAttribL1ui64NV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL2ui64NV(UInt32 index, UInt64 x, UInt64 y);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL2ui64NV pglVertexAttribL2ui64NV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL3ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL3ui64NV pglVertexAttribL3ui64NV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribL4ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z, UInt64 w);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL4ui64NV pglVertexAttribL4ui64NV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL1ui64vNV(UInt32 index, UInt64* v);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL1ui64vNV pglVertexAttribL1ui64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL2ui64vNV(UInt32 index, UInt64* v);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL2ui64vNV pglVertexAttribL2ui64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL3ui64vNV(UInt32 index, UInt64* v);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL3ui64vNV pglVertexAttribL3ui64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertexAttribL4ui64vNV(UInt32 index, UInt64* v);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribL4ui64vNV pglVertexAttribL4ui64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribLi64vNV(UInt32 index, Int32 pname, Int64* @params);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetVertexAttribLi64vNV pglGetVertexAttribLi64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetVertexAttribLui64vNV(UInt32 index, Int32 pname, UInt64* @params);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glGetVertexAttribLui64vNV pglGetVertexAttribLui64vNV;

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertexAttribLFormatNV(UInt32 index, Int32 size, Int32 type, Int32 stride);

			[RequiredByFeature("GL_NV_vertex_attrib_integer_64bit", Api = "gl|glcore")]
			[ThreadStatic]
			internal static glVertexAttribLFormatNV pglVertexAttribLFormatNV;

		}
	}

}
