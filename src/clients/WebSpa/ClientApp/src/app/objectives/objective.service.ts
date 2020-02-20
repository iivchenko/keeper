import { Injectable, Inject } from '@angular/core'
import { HttpClient } from '@angular/common/http'

@Injectable()
export class ObjectiveService {

  private url: string = '';
  private http: HttpClient;

  private objectives: Objective[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.url = baseUrl;
    this.http = http;
  }

  getObjectives(): Objective[] {
    let url = this.url + 'api/objectives';

    this.http.get(url).subscribe((data: Objective[]) => this.objectives = data);

    return this.objectives;
  }
}

export class Objective {
  name: string;
  description: string;
}
