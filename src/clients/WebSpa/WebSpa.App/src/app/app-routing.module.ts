import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { ObjectiveList } from './objectives/objective-list/objective-list.component'


const routes: Routes = [
  { path: '', redirectTo: '/objectives', pathMatch: 'full' },
  { path: 'objectives', component: ObjectiveList }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
