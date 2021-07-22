//Copyright 2021, ALT LLC. All Rights Reserved.
//This file is part of Antilatency SDK.
//It is subject to the license terms in the LICENSE file found in the top-level directory
//of this distribution and at http://www.antilatency.com/eula
//You may not use this file except in compliance with the License.
//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.
#pragma warning disable IDE1006 // Do not warn about naming style violations
#pragma warning disable IDE0017 // Do not suggest to simplify object initialization
using System.Runtime.InteropServices; //GuidAttribute
namespace Antilatency.Alt.Environment {

[System.Serializable]
[System.Runtime.InteropServices.StructLayout(LayoutKind.Sequential)]
public partial struct MarkerIndex {
	public static readonly MarkerIndex MaximumValidMarkerIndex = new MarkerIndex(){ value = 0xFFFFFFF0 };
	public static readonly MarkerIndex Invalid = new MarkerIndex(){ value = 0xFFFFFFFE };
	public static readonly MarkerIndex Unknown = new MarkerIndex(){ value = 0xFFFFFFFF };
	[System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
	public uint value;
	public override string ToString() {
		switch (value) {
			case 0xFFFFFFF0: return "MaximumValidMarkerIndex";
			case 0xFFFFFFFE: return "Invalid";
			case 0xFFFFFFFF: return "Unknown";
		}
		return value.ToString();
	}
	public static implicit operator uint(MarkerIndex value) { return value.value;}
	public static explicit operator MarkerIndex(uint value) { return new MarkerIndex() { value = value }; }
}

[Guid("c257c858-f296-43b7-b6b5-c14b9afb1a13")]
public interface IEnvironment : Antilatency.InterfaceContract.IInterface {
	Antilatency.InterfaceContract.Bool isMutable();
	Antilatency.Math.float3[] getMarkers();
	Antilatency.InterfaceContract.Bool filterRay(Antilatency.Math.float3 up, Antilatency.Math.float3 ray);
	/// <param name = "raysUpSpace">
	/// rays directions. Normalized
	/// </param>
	Antilatency.InterfaceContract.Bool match(Antilatency.Math.float3[] raysUpSpace, out Antilatency.Alt.Environment.MarkerIndex[] markersIndices, out Antilatency.Math.floatP3Q poseOfUpSpace);
	/// <summary>Match rays to markers by known position</summary>
	/// <param name = "rays">
	/// rays directions world space. Normalized
	/// </param>
	/// <param name = "origin">
	/// Common rays origin world space
	/// </param>
	/// <returns>Indices of corresponding markers. result.size == rays.size</returns>
	Antilatency.Alt.Environment.MarkerIndex[] matchByPosition(Antilatency.Math.float3[] rays, Antilatency.Math.float3 origin);
}
namespace Details {
	public class IEnvironmentWrapper : Antilatency.InterfaceContract.Details.IInterfaceWrapper, IEnvironment {
		private IEnvironmentRemap.VMT _VMT = new IEnvironmentRemap.VMT();
		protected new int GetTotalNativeMethodsCount() {
		    return base.GetTotalNativeMethodsCount() + typeof(IEnvironmentRemap.VMT).GetFields().Length;
		}
		public IEnvironmentWrapper(System.IntPtr obj) : base(obj) {
		    _VMT = LoadVMT<IEnvironmentRemap.VMT>(base.GetTotalNativeMethodsCount());
		}
		public Antilatency.InterfaceContract.Bool isMutable() {
			Antilatency.InterfaceContract.Bool result;
			Antilatency.InterfaceContract.Bool resultMarshaler;
			HandleExceptionCode(_VMT.isMutable(_object, out resultMarshaler));
			result = resultMarshaler;
			return result;
		}
		public Antilatency.Math.float3[] getMarkers() {
			Antilatency.Math.float3[] result;
			var resultMarshaler = Antilatency.InterfaceContract.Details.ArrayOutMarshaler.create<Antilatency.Math.float3>();
			HandleExceptionCode(_VMT.getMarkers(_object, resultMarshaler));
			result = resultMarshaler.value;
			resultMarshaler.Dispose();
			return result;
		}
		public Antilatency.InterfaceContract.Bool filterRay(Antilatency.Math.float3 up, Antilatency.Math.float3 ray) {
			Antilatency.InterfaceContract.Bool result;
			Antilatency.InterfaceContract.Bool resultMarshaler;
			HandleExceptionCode(_VMT.filterRay(_object, up, ray, out resultMarshaler));
			result = resultMarshaler;
			return result;
		}
		public Antilatency.InterfaceContract.Bool match(Antilatency.Math.float3[] raysUpSpace, out Antilatency.Alt.Environment.MarkerIndex[] markersIndices, out Antilatency.Math.floatP3Q poseOfUpSpace) {
			Antilatency.InterfaceContract.Bool result;
			Antilatency.InterfaceContract.Bool resultMarshaler;
			var raysUpSpaceMarshaler = Antilatency.InterfaceContract.Details.ArrayInMarshaler.create(raysUpSpace);
			var markersIndicesMarshaler = Antilatency.InterfaceContract.Details.ArrayOutMarshaler.create<Antilatency.Alt.Environment.MarkerIndex>();
			Antilatency.Math.floatP3Q poseOfUpSpaceMarshaler;
			HandleExceptionCode(_VMT.match(_object, raysUpSpaceMarshaler, markersIndicesMarshaler, out poseOfUpSpaceMarshaler, out resultMarshaler));
			raysUpSpaceMarshaler.Dispose();
			markersIndices = markersIndicesMarshaler.value;
			markersIndicesMarshaler.Dispose();
			poseOfUpSpace = poseOfUpSpaceMarshaler;
			result = resultMarshaler;
			return result;
		}
		public Antilatency.Alt.Environment.MarkerIndex[] matchByPosition(Antilatency.Math.float3[] rays, Antilatency.Math.float3 origin) {
			Antilatency.Alt.Environment.MarkerIndex[] result;
			var resultMarshaler = Antilatency.InterfaceContract.Details.ArrayOutMarshaler.create<Antilatency.Alt.Environment.MarkerIndex>();
			var raysMarshaler = Antilatency.InterfaceContract.Details.ArrayInMarshaler.create(rays);
			HandleExceptionCode(_VMT.matchByPosition(_object, raysMarshaler, origin, resultMarshaler));
			raysMarshaler.Dispose();
			result = resultMarshaler.value;
			resultMarshaler.Dispose();
			return result;
		}
	}
	public class IEnvironmentRemap : Antilatency.InterfaceContract.Details.IInterfaceRemap {
		public new struct VMT {
			public delegate Antilatency.InterfaceContract.ExceptionCode isMutableDelegate(System.IntPtr _this, out Antilatency.InterfaceContract.Bool result);
			public delegate Antilatency.InterfaceContract.ExceptionCode getMarkersDelegate(System.IntPtr _this, Antilatency.InterfaceContract.Details.ArrayOutMarshaler.Intermediate result);
			public delegate Antilatency.InterfaceContract.ExceptionCode filterRayDelegate(System.IntPtr _this, Antilatency.Math.float3 up, Antilatency.Math.float3 ray, out Antilatency.InterfaceContract.Bool result);
			public delegate Antilatency.InterfaceContract.ExceptionCode matchDelegate(System.IntPtr _this, Antilatency.InterfaceContract.Details.ArrayInMarshaler.Intermediate raysUpSpace, Antilatency.InterfaceContract.Details.ArrayOutMarshaler.Intermediate markersIndices, out Antilatency.Math.floatP3Q poseOfUpSpace, out Antilatency.InterfaceContract.Bool result);
			public delegate Antilatency.InterfaceContract.ExceptionCode matchByPositionDelegate(System.IntPtr _this, Antilatency.InterfaceContract.Details.ArrayInMarshaler.Intermediate rays, Antilatency.Math.float3 origin, Antilatency.InterfaceContract.Details.ArrayOutMarshaler.Intermediate result);
			#pragma warning disable 0649
			public isMutableDelegate isMutable;
			public getMarkersDelegate getMarkers;
			public filterRayDelegate filterRay;
			public matchDelegate match;
			public matchByPositionDelegate matchByPosition;
			#pragma warning restore 0649
		}
		public new static readonly NativeInterfaceVmt NativeVmt;
		static IEnvironmentRemap() {
			var vmtBlocks = new System.Collections.Generic.List<object>();
			AppendVmt(vmtBlocks);
			NativeVmt = new NativeInterfaceVmt(vmtBlocks);
		}
		protected static new void AppendVmt(System.Collections.Generic.List<object> buffer) {
			Antilatency.InterfaceContract.Details.IInterfaceRemap.AppendVmt(buffer);
			var vmt = new VMT();
			vmt.isMutable = (System.IntPtr _this, out Antilatency.InterfaceContract.Bool result) => {
				try {
					var obj = GetContext(_this) as IEnvironment;
					var resultMarshaler = obj.isMutable();
					result = resultMarshaler;
				}
				catch (System.Exception ex) {
					result = default(Antilatency.InterfaceContract.Bool);
					return handleRemapException(ex, _this);
				}
				return Antilatency.InterfaceContract.ExceptionCode.Ok;
			};
			vmt.getMarkers = (System.IntPtr _this, Antilatency.InterfaceContract.Details.ArrayOutMarshaler.Intermediate result) => {
				try {
					var obj = GetContext(_this) as IEnvironment;
					var resultMarshaler = obj.getMarkers();
					result.assign(resultMarshaler);
				}
				catch (System.Exception ex) {
					return handleRemapException(ex, _this);
				}
				return Antilatency.InterfaceContract.ExceptionCode.Ok;
			};
			vmt.filterRay = (System.IntPtr _this, Antilatency.Math.float3 up, Antilatency.Math.float3 ray, out Antilatency.InterfaceContract.Bool result) => {
				try {
					var obj = GetContext(_this) as IEnvironment;
					var resultMarshaler = obj.filterRay(up, ray);
					result = resultMarshaler;
				}
				catch (System.Exception ex) {
					result = default(Antilatency.InterfaceContract.Bool);
					return handleRemapException(ex, _this);
				}
				return Antilatency.InterfaceContract.ExceptionCode.Ok;
			};
			vmt.match = (System.IntPtr _this, Antilatency.InterfaceContract.Details.ArrayInMarshaler.Intermediate raysUpSpace, Antilatency.InterfaceContract.Details.ArrayOutMarshaler.Intermediate markersIndices, out Antilatency.Math.floatP3Q poseOfUpSpace, out Antilatency.InterfaceContract.Bool result) => {
				try {
					var obj = GetContext(_this) as IEnvironment;
					Antilatency.Alt.Environment.MarkerIndex[] markersIndicesMarshaler;
					Antilatency.Math.floatP3Q poseOfUpSpaceMarshaler;
					poseOfUpSpace = default(Antilatency.Math.floatP3Q);
					var resultMarshaler = obj.match(raysUpSpace.toArray<Antilatency.Math.float3>(), out markersIndicesMarshaler, out poseOfUpSpaceMarshaler);
					markersIndices.assign(markersIndicesMarshaler);
					poseOfUpSpace = poseOfUpSpaceMarshaler;
					result = resultMarshaler;
				}
				catch (System.Exception ex) {
					result = default(Antilatency.InterfaceContract.Bool);
					poseOfUpSpace = default(Antilatency.Math.floatP3Q);
					return handleRemapException(ex, _this);
				}
				return Antilatency.InterfaceContract.ExceptionCode.Ok;
			};
			vmt.matchByPosition = (System.IntPtr _this, Antilatency.InterfaceContract.Details.ArrayInMarshaler.Intermediate rays, Antilatency.Math.float3 origin, Antilatency.InterfaceContract.Details.ArrayOutMarshaler.Intermediate result) => {
				try {
					var obj = GetContext(_this) as IEnvironment;
					var resultMarshaler = obj.matchByPosition(rays.toArray<Antilatency.Math.float3>(), origin);
					result.assign(resultMarshaler);
				}
				catch (System.Exception ex) {
					return handleRemapException(ex, _this);
				}
				return Antilatency.InterfaceContract.ExceptionCode.Ok;
			};
			buffer.Add(vmt);
		}
		public IEnvironmentRemap() { }
		public IEnvironmentRemap(System.IntPtr context, ushort lifetimeId) {
			AllocateNativeInterface(NativeVmt.Handle, context, lifetimeId);
		}
	}
}


}
