// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: common/common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Pb {

  /// <summary>Holder for reflection information generated from common/common.proto</summary>
  public static partial class CommonReflection {

    #region Descriptor
    /// <summary>File descriptor for common/common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNjb21tb24vY29tbW9uLnByb3RvIm0KBkVudGl0eRIKCgJpZBgBIAEoCRIN",
            "CgVvd25lchgCIAEoCRIaCghwb3NpdGlvbhgDIAEoCzIILlZlY3RvcjMSDwoH",
            "c3BhY2VpZBgEIAEoCRIMCgRuYW1lGAUgASgJEg0KBWV0eXBlGAYgASgFIioK",
            "B1ZlY3RvcjMSCQoBeBgBIAEoAhIJCgF5GAIgASgCEgkKAXoYAyABKAJCC1oE",
            "LjtwYqoCAlBiYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.Entity), global::Pb.Entity.Parser, new[]{ "Id", "Owner", "Position", "Spaceid", "Name", "Etype" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Pb.Vector3), global::Pb.Vector3.Parser, new[]{ "X", "Y", "Z" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Entity : pb::IMessage<Entity> {
    private static readonly pb::MessageParser<Entity> _parser = new pb::MessageParser<Entity>(() => new Entity());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Entity> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.CommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Entity() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Entity(Entity other) : this() {
      id_ = other.id_;
      owner_ = other.owner_;
      position_ = other.position_ != null ? other.position_.Clone() : null;
      spaceid_ = other.spaceid_;
      name_ = other.name_;
      etype_ = other.etype_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Entity Clone() {
      return new Entity(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "owner" field.</summary>
    public const int OwnerFieldNumber = 2;
    private string owner_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Owner {
      get { return owner_; }
      set {
        owner_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 3;
    private global::Pb.Vector3 position_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Pb.Vector3 Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    /// <summary>Field number for the "spaceid" field.</summary>
    public const int SpaceidFieldNumber = 4;
    private string spaceid_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Spaceid {
      get { return spaceid_; }
      set {
        spaceid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 5;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "etype" field.</summary>
    public const int EtypeFieldNumber = 6;
    private int etype_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Etype {
      get { return etype_; }
      set {
        etype_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Entity);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Entity other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Owner != other.Owner) return false;
      if (!object.Equals(Position, other.Position)) return false;
      if (Spaceid != other.Spaceid) return false;
      if (Name != other.Name) return false;
      if (Etype != other.Etype) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Owner.Length != 0) hash ^= Owner.GetHashCode();
      if (position_ != null) hash ^= Position.GetHashCode();
      if (Spaceid.Length != 0) hash ^= Spaceid.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Etype != 0) hash ^= Etype.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Owner.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Owner);
      }
      if (position_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Position);
      }
      if (Spaceid.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Spaceid);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Name);
      }
      if (Etype != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Etype);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Owner.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Owner);
      }
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      if (Spaceid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Spaceid);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Etype != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Etype);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Entity other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Owner.Length != 0) {
        Owner = other.Owner;
      }
      if (other.position_ != null) {
        if (position_ == null) {
          Position = new global::Pb.Vector3();
        }
        Position.MergeFrom(other.Position);
      }
      if (other.Spaceid.Length != 0) {
        Spaceid = other.Spaceid;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Etype != 0) {
        Etype = other.Etype;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Owner = input.ReadString();
            break;
          }
          case 26: {
            if (position_ == null) {
              Position = new global::Pb.Vector3();
            }
            input.ReadMessage(Position);
            break;
          }
          case 34: {
            Spaceid = input.ReadString();
            break;
          }
          case 42: {
            Name = input.ReadString();
            break;
          }
          case 48: {
            Etype = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Vector3 : pb::IMessage<Vector3> {
    private static readonly pb::MessageParser<Vector3> _parser = new pb::MessageParser<Vector3>(() => new Vector3());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Vector3> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Pb.CommonReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vector3() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vector3(Vector3 other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Vector3 Clone() {
      return new Vector3(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private float x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private float y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 3;
    private float z_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Vector3);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Vector3 other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(X, other.X)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Y, other.Y)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Z, other.Z)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(X);
      if (Y != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Y);
      if (Z != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Z);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(X);
      }
      if (Y != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Y);
      }
      if (Z != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Z);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0F) {
        size += 1 + 4;
      }
      if (Y != 0F) {
        size += 1 + 4;
      }
      if (Z != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Vector3 other) {
      if (other == null) {
        return;
      }
      if (other.X != 0F) {
        X = other.X;
      }
      if (other.Y != 0F) {
        Y = other.Y;
      }
      if (other.Z != 0F) {
        Z = other.Z;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 13: {
            X = input.ReadFloat();
            break;
          }
          case 21: {
            Y = input.ReadFloat();
            break;
          }
          case 29: {
            Z = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
