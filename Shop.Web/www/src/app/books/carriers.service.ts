import { Injectable } from '@angular/core';
import { Carrier } from "./carrier";

@Injectable()
export class CarriersService {
    constructor() { }

    getAllCarriers(): Array<Carrier> {
        return [
                new Carrier(1, "PenDrive"),
                new Carrier(2, "płyta CD"),
                new Carrier(3,"płyta DVD")
        ] 
    }
}
