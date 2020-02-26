import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RouterModule } from '@angular/router';

import { ObjectiveList} from './objectives/objective-list/objective-list.component'
import { ObjectiveListItem} from './objectives/objective-list-item/objective-list-item.component'
import { ObjectiveService} from './objectives/objective.service'

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
    RouterModule.forRoot([
      { path: 'objectives', component: ObjectiveList }
    ])
  ],
  providers: [ObjectiveService],
  bootstrap: [AppComponent]
})
export class AppModule { }
