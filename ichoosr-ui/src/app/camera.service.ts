import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Camera } from 'src/Models/Camera';

@Injectable({
  providedIn: 'root'
})
export class CameraService {

  private baseUrl = 'http://localhost:51400/';
  private cameraUrl = 'api/camera';


  constructor(private http: HttpClient) { }


  getCameras(): Observable<Camera[]> {
    const fullUrl = `${this.baseUrl}${this.cameraUrl}`;

    const cameras = this.http.get<Camera[]>(fullUrl);

    return cameras;
  }

  getCamerasByName(name: string): Observable<Camera[]> {
    const params = `?name=${name}`;
    const fullUrl = `${this.baseUrl}${this.cameraUrl}${params}`;

    const cameras = this.http.get<Camera[]>(fullUrl);

    return cameras;
  }
}
