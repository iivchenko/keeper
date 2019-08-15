import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { ObjectiveListItem } from './objective-list-item/objective-list-item.component';
import { ObjectiveList } from './objective-list/objective-list.component'
import { ObjectiveService } from './objective.service'

@NgModule({
  declarations: [
    ObjectiveListItem,
    ObjectiveList
  ],
  imports: [
    BrowserModule
  ],
  providers: [ObjectiveService],
  bootstrap: [ObjectiveList]
})
export class AppModule { }
