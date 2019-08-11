import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { ObjectiveItem } from './objective-item/objective-item.component';
import { ObjectiveList } from './objective-list/objective-list.component'

@NgModule({
  declarations: [
    ObjectiveItem,
    ObjectiveList
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [ObjectiveList]
})
export class AppModule { }
