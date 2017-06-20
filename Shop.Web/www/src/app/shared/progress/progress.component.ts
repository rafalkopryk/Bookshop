import { Component, OnInit, OnDestroy } from '@angular/core';
import { Subscription } from 'rxjs/Subscription';

import { ProgressService } from './progress.service';

@Component({
  selector: 'app-progress',
  templateUrl: './progress.component.html',
  styleUrls: ['./progress.component.scss']
})
export class ProgressComponent implements OnInit {

    show:boolean;

    private subscription: Subscription;

    constructor(
        private progressService: ProgressService
    ) { }

    ngOnInit() {
        this.show = false; 
        this.subscription = this.progressService.progressStatus
            .subscribe(result => {
                if(result==false)
                  setTimeout(()=>{this.show = result},300);
                else
                  this.show = result;
            });
    }

    ngOnDestroy() {
        this.subscription.unsubscribe();
    }

}
