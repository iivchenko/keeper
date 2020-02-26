import { Injectable, Inject } from '@angular/core'
import { HttpClient } from '@angular/common/http'

@Injectable()
export class ObjectiveService {

  private url: string = '';
  private http: HttpClient;

  private objectives: Objective[];

  constructor(http: HttpClient) {
    this.url = "";
    this.http = http;
  }

  getObjectives(): Objective[] {
    //let url = this.url + 'api/objectives?skip=0&take=1000'; // TODO: Make a proper paging

    //this.http.get(url).subscribe((data: Objective[]) => this.objectives = data);
    let o = new Objective();
    o.description = "test";
    o.name = "hello";

    this.objectives = [o];

    return this.objectives;
  }
}

export class Objective {
  name: string;
  description: string;
}
