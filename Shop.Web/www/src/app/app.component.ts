import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
    title = 'app';
    tabLinks = [
        { label: 'Wszystkie', link: 'books' },
        { label: 'Audiobooki', link: 'audiobooks' },
        { label: 'E-Booki', link: 'ebooks' },
    ];
}
