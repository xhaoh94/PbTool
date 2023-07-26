export namespace Pb{
	export interface C2S_RegisterAccount{
		account?:string;
		password?:string;
	}
	export interface S2C_RegisterAccount{
		error?:ErrCode;
	}
	export interface C2S_LoginGame{
		account?:string;
		password?:string;
	}
	export interface S2C_LoginGame{
		error?:ErrCode;
	}
	export interface C2S_RoleList{
	}
	export interface S2C_RoleList{
		error?:ErrCode;
		role_list?:Entity[];
	}
	export interface C2S_CreateRole{
		name?:string;
	}
	export interface S2C_CreateRole{
		error?:ErrCode;
		role?:Entity;
	}
}
