import { Component, OnInit } from "@angular/core"
import { ObjectiveListItem } from '../objective-list-item/objective-list-item.component';
import { ObjectiveService} from '../objective.service'

@Component({
    selector: 'objective-list',
    templateUrl: './objective-list.component.html'
})

export class ObjectiveList implements OnInit {
    
    private objectives : any

    constructor(private objectiveService : ObjectiveService) {
    }

    ngOnInit(){
        this.objectives = this.objectiveService.getObjectives();
    }
}