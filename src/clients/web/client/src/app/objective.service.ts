import { Injectable } from '@angular/core'

@Injectable()
export class ObjectiveService {
    getObjectives() {
        return OBJECTIVES;
    }
}

const OBJECTIVES = [
    {
        name: 'test1',
        description: 'description1'
    },
    {
        name: 'test2',
        description: 'description2'
    }]