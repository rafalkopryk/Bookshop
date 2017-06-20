import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs/BehaviorSubject';

@Injectable()
export class ProgressService {

   public progressStatus: BehaviorSubject<boolean> = new BehaviorSubject<boolean>(false);

    show(){
        this.progressStatus.next(true);
    }

    hide(){
        this.progressStatus.next(false);
    }

}
