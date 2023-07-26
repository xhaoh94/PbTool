export namespace Pb{
	export interface Entity{
		id?:string;
		owner?:string;
		position?:Vector3;
		spaceid?:string;
		name?:string;
		etype?:number;
	}
	export interface Vector3{
		x?:number;
		y?:number;
		z?:number;
	}
}
