import { LegoPart } from "app/models/lego-part";

export class LegoToy {
    id: string;
    name: string;
    description: string;
    price: number;
    parts: LegoPart[];
    imageUrl: string;
}
