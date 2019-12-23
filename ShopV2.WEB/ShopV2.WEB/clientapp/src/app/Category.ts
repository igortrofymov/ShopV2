import { Product } from './Product';

export class Category {
    constructor(
        public name?:string,
        public id?:number,
        public description?:string,
        public products?:Product[]
    ){}
}
