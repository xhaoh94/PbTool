// Code generated by protoc-gen-go. DO NOT EDIT.
// source: rpc/rpc_entergame.proto

package pb

import (
	context "context"
	fmt "fmt"
	proto "github.com/golang/protobuf/proto"
	grpc "google.golang.org/grpc"
	codes "google.golang.org/grpc/codes"
	status "google.golang.org/grpc/status"
	math "math"
)

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = fmt.Errorf
var _ = math.Inf

// This is a compile-time assertion to ensure that this generated file
// is compatible with the proto package it is being compiled against.
// A compilation error at this line likely means your copy of the
// proto package needs to be updated.
const _ = proto.ProtoPackageIsVersion3 // please upgrade the proto package

type G2S_CreateSpace struct {
	Spaceid              string   `protobuf:"bytes,1,opt,name=spaceid,proto3" json:"spaceid,omitempty"`
	XXX_NoUnkeyedLiteral struct{} `json:"-"`
	XXX_unrecognized     []byte   `json:"-"`
	XXX_sizecache        int32    `json:"-"`
}

func (m *G2S_CreateSpace) Reset()         { *m = G2S_CreateSpace{} }
func (m *G2S_CreateSpace) String() string { return proto.CompactTextString(m) }
func (*G2S_CreateSpace) ProtoMessage()    {}
func (*G2S_CreateSpace) Descriptor() ([]byte, []int) {
	return fileDescriptor_a2d685321b612d6f, []int{0}
}

func (m *G2S_CreateSpace) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_G2S_CreateSpace.Unmarshal(m, b)
}
func (m *G2S_CreateSpace) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_G2S_CreateSpace.Marshal(b, m, deterministic)
}
func (m *G2S_CreateSpace) XXX_Merge(src proto.Message) {
	xxx_messageInfo_G2S_CreateSpace.Merge(m, src)
}
func (m *G2S_CreateSpace) XXX_Size() int {
	return xxx_messageInfo_G2S_CreateSpace.Size(m)
}
func (m *G2S_CreateSpace) XXX_DiscardUnknown() {
	xxx_messageInfo_G2S_CreateSpace.DiscardUnknown(m)
}

var xxx_messageInfo_G2S_CreateSpace proto.InternalMessageInfo

func (m *G2S_CreateSpace) GetSpaceid() string {
	if m != nil {
		return m.Spaceid
	}
	return ""
}

type S2G_CreateSpace struct {
	Error                ErrCode  `protobuf:"varint,1,opt,name=error,proto3,enum=ErrCode" json:"error,omitempty"`
	XXX_NoUnkeyedLiteral struct{} `json:"-"`
	XXX_unrecognized     []byte   `json:"-"`
	XXX_sizecache        int32    `json:"-"`
}

func (m *S2G_CreateSpace) Reset()         { *m = S2G_CreateSpace{} }
func (m *S2G_CreateSpace) String() string { return proto.CompactTextString(m) }
func (*S2G_CreateSpace) ProtoMessage()    {}
func (*S2G_CreateSpace) Descriptor() ([]byte, []int) {
	return fileDescriptor_a2d685321b612d6f, []int{1}
}

func (m *S2G_CreateSpace) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_S2G_CreateSpace.Unmarshal(m, b)
}
func (m *S2G_CreateSpace) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_S2G_CreateSpace.Marshal(b, m, deterministic)
}
func (m *S2G_CreateSpace) XXX_Merge(src proto.Message) {
	xxx_messageInfo_S2G_CreateSpace.Merge(m, src)
}
func (m *S2G_CreateSpace) XXX_Size() int {
	return xxx_messageInfo_S2G_CreateSpace.Size(m)
}
func (m *S2G_CreateSpace) XXX_DiscardUnknown() {
	xxx_messageInfo_S2G_CreateSpace.DiscardUnknown(m)
}

var xxx_messageInfo_S2G_CreateSpace proto.InternalMessageInfo

func (m *S2G_CreateSpace) GetError() ErrCode {
	if m != nil {
		return m.Error
	}
	return ErrCode_Success
}

func init() {
	proto.RegisterType((*G2S_CreateSpace)(nil), "G2S_CreateSpace")
	proto.RegisterType((*S2G_CreateSpace)(nil), "S2G_CreateSpace")
}

func init() { proto.RegisterFile("rpc/rpc_entergame.proto", fileDescriptor_a2d685321b612d6f) }

var fileDescriptor_a2d685321b612d6f = []byte{
	// 172 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0xff, 0xe2, 0x12, 0x2f, 0x2a, 0x48, 0xd6,
	0x2f, 0x2a, 0x48, 0x8e, 0x4f, 0xcd, 0x2b, 0x49, 0x2d, 0x4a, 0x4f, 0xcc, 0x4d, 0xd5, 0x2b, 0x28,
	0xca, 0x2f, 0xc9, 0x97, 0x12, 0x49, 0xce, 0xcf, 0xcd, 0xcd, 0xcf, 0xd3, 0x4f, 0x2d, 0x2a, 0x4a,
	0xce, 0x4f, 0x81, 0x8a, 0x2a, 0x69, 0x73, 0xf1, 0xbb, 0x1b, 0x05, 0xc7, 0x3b, 0x17, 0xa5, 0x26,
	0x96, 0xa4, 0x06, 0x17, 0x24, 0x26, 0xa7, 0x0a, 0x49, 0x70, 0xb1, 0x17, 0x83, 0x18, 0x99, 0x29,
	0x12, 0x8c, 0x0a, 0x8c, 0x1a, 0x9c, 0x41, 0x30, 0xae, 0x92, 0x21, 0x17, 0x7f, 0xb0, 0x91, 0x3b,
	0x8a, 0x62, 0x39, 0x2e, 0xd6, 0xd4, 0xa2, 0xa2, 0xfc, 0x22, 0xb0, 0x52, 0x3e, 0x23, 0x0e, 0x3d,
	0xd7, 0xa2, 0x22, 0xe7, 0xfc, 0x94, 0xd4, 0x20, 0x88, 0xb0, 0x91, 0x33, 0x17, 0x8f, 0x27, 0xb2,
	0x7a, 0x63, 0x2e, 0x6e, 0x64, 0xae, 0x80, 0x1e, 0x9a, 0xed, 0x52, 0x02, 0x7a, 0x68, 0x56, 0x28,
	0x31, 0x38, 0xb1, 0x45, 0xb1, 0xe8, 0x59, 0x17, 0x24, 0x25, 0xb1, 0x81, 0xdd, 0x6c, 0x0c, 0x08,
	0x00, 0x00, 0xff, 0xff, 0x9d, 0x7a, 0x5b, 0x7f, 0xe4, 0x00, 0x00, 0x00,
}

// Reference imports to suppress errors if they are not otherwise used.
var _ context.Context
var _ grpc.ClientConn

// This is a compile-time assertion to ensure that this generated file
// is compatible with the grpc package it is being compiled against.
const _ = grpc.SupportPackageIsVersion4

// ICreateSpaceClient is the client API for ICreateSpace service.
//
// For semantics around ctx use and closing/ending streaming RPCs, please refer to https://godoc.org/google.golang.org/grpc#ClientConn.NewStream.
type ICreateSpaceClient interface {
	CreateSpace(ctx context.Context, in *G2S_CreateSpace, opts ...grpc.CallOption) (*S2G_CreateSpace, error)
}

type iCreateSpaceClient struct {
	cc *grpc.ClientConn
}

func NewICreateSpaceClient(cc *grpc.ClientConn) ICreateSpaceClient {
	return &iCreateSpaceClient{cc}
}

func (c *iCreateSpaceClient) CreateSpace(ctx context.Context, in *G2S_CreateSpace, opts ...grpc.CallOption) (*S2G_CreateSpace, error) {
	out := new(S2G_CreateSpace)
	err := c.cc.Invoke(ctx, "/ICreateSpace/CreateSpace", in, out, opts...)
	if err != nil {
		return nil, err
	}
	return out, nil
}

// ICreateSpaceServer is the server API for ICreateSpace service.
type ICreateSpaceServer interface {
	CreateSpace(context.Context, *G2S_CreateSpace) (*S2G_CreateSpace, error)
}

// UnimplementedICreateSpaceServer can be embedded to have forward compatible implementations.
type UnimplementedICreateSpaceServer struct {
}

func (*UnimplementedICreateSpaceServer) CreateSpace(ctx context.Context, req *G2S_CreateSpace) (*S2G_CreateSpace, error) {
	return nil, status.Errorf(codes.Unimplemented, "method CreateSpace not implemented")
}

func RegisterICreateSpaceServer(s *grpc.Server, srv ICreateSpaceServer) {
	s.RegisterService(&_ICreateSpace_serviceDesc, srv)
}

func _ICreateSpace_CreateSpace_Handler(srv interface{}, ctx context.Context, dec func(interface{}) error, interceptor grpc.UnaryServerInterceptor) (interface{}, error) {
	in := new(G2S_CreateSpace)
	if err := dec(in); err != nil {
		return nil, err
	}
	if interceptor == nil {
		return srv.(ICreateSpaceServer).CreateSpace(ctx, in)
	}
	info := &grpc.UnaryServerInfo{
		Server:     srv,
		FullMethod: "/ICreateSpace/CreateSpace",
	}
	handler := func(ctx context.Context, req interface{}) (interface{}, error) {
		return srv.(ICreateSpaceServer).CreateSpace(ctx, req.(*G2S_CreateSpace))
	}
	return interceptor(ctx, in, info, handler)
}

var _ICreateSpace_serviceDesc = grpc.ServiceDesc{
	ServiceName: "ICreateSpace",
	HandlerType: (*ICreateSpaceServer)(nil),
	Methods: []grpc.MethodDesc{
		{
			MethodName: "CreateSpace",
			Handler:    _ICreateSpace_CreateSpace_Handler,
		},
	},
	Streams:  []grpc.StreamDesc{},
	Metadata: "rpc/rpc_entergame.proto",
}
