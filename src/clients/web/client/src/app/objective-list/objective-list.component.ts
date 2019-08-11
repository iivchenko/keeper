import { Component } from "@angular/core"
import { ObjectiveItem } from '../objective-item/objective-item.component';

@Component({
    selector: 'objective-list',
    templateUrl: './objective-list.component.html'
})

export class ObjectiveList {
    public objective1:ObjectiveItem = {
        name: 'test1',
        description: 'description1'
    }

    public objective2:ObjectiveItem = {
        name: 'test2',
        description: 'description2'
    }
}