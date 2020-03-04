import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { environment } from './../environments/environment'
import { ObjectiveList} from './objectives/objective-list/objective-list.component'
import { ObjectiveListItem} from './objectives/objective-list-item/objective-list-item.component'
import { ObjectiveService, ObjectivesApiUrl} from './objectives/objective.service'

@NgModule({
  declarations: [
    AppComponent,
    ObjectiveList,
    ObjectiveListItem
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    NgbModule
  ],
  providers: [
    {
      provide: ObjectivesApiUrl,
      useValue: environment.webSpaServerUrl
    },
    ObjectiveService, 
    HttpClient],
  bootstrap: [AppComponent]
})
export class AppModule { }
