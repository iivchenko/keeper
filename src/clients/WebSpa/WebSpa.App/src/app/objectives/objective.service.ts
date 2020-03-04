import { Injectable, Inject, InjectionToken } from '@angular/core'
import { HttpClient } from '@angular/common/http'
import { Observable} from 'rxjs';
import { map } from 'rxjs/operators';

export const ObjectivesApiUrl = new InjectionToken<string>('ObjectivesApiUrl');

@Injectable()
export class ObjectiveService {

  private url: string;
  private http: HttpClient;

  constructor(http: HttpClient, @Inject(ObjectivesApiUrl) apiUrl: string) {
    this.url = apiUrl;
    this.http = http;
  }

  getObjectives(): Observable<Objective[]> {

    let url = this.url + 'api/objectives?skip=0&take=1000'; // TODO: Make a proper paging

    return this.http.get<Objective[]>(url);
  }

  
}

export class Objective {
  name: string;
  description: string;
}
