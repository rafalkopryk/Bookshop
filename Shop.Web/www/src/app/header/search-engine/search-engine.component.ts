import { Component, OnInit } from '@angular/core';
import { SearchService } from "app/shared/search.service";

@Component({
  selector: 'app-search-engine',
  templateUrl: './search-engine.component.html',
  styleUrls: ['./search-engine.component.scss']
})
export class SearchEngineComponent implements OnInit {

  query: string;

  constructor(private searchService:SearchService) { }

  ngOnInit() {
  }

  search(clear?: boolean) {
      if (clear) this.query = '';
      this.searchService.addQuery(this.query);
  }

}
