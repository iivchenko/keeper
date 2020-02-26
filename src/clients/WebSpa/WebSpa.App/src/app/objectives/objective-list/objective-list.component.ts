import { Component, OnInit } from "@angular/core"
import { ObjectiveService, Objective} from '../objective.service'

@Component({
  selector: 'objective-list',
  templateUrl: './objective-list.component.html'
})

export class ObjectiveList implements OnInit {
    
  public objectives: Objective[]

  constructor(private objectiveService : ObjectiveService) {
  }

  ngOnInit(){
    this.objectives = this.objectiveService.getObjectives();
  }
}
