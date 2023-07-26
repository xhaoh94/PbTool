export namespace Pb{
	export interface C2S_EnterGame{
		roleid?:string;
	}
	export interface S2C_EnterGame{
		error?:ErrCode;
		self?:Entity;
		entitys?:Entity[];
	}
}
