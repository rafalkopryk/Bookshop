import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';

@Injectable()
export class PreloaderService {

   public loaderStatus: BehaviorSubject<boolean> = new BehaviorSubject<boolean>(false);

    displayLoader(value: boolean) {
        this.loaderStatus.next(value);
    }

}
