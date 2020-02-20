import { Component, Input } from "@angular/core"

@Component({
    selector: 'objective-list-item',
    templateUrl: './objective-list-item.component.html'
})

export class ObjectiveListItem{
     @Input() public name : string
     @Input() public description : string
}