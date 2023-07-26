export namespace Pb{
	export interface Bcst_EntityEnter{
		spaceid?:string;
		entitys?:Entity[];
	}
	export interface Bcst_EntityLeave{
		spaceid?:string;
		eids?:string[];
	}
	export interface Bcst_EntityMove{
		spaceid?:string;
		eid?:string;
		position?:Vector3;
	}
}
