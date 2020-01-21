import { Component, OnInit } from '@angular/core';
import { Camera } from 'src/Models/Camera';
import { CameraService } from '../camera.service';

@Component({
  selector: 'app-camera',
  templateUrl: './camera.component.html',
  styleUrls: ['./camera.component.sass']
})
export class CameraComponent implements OnInit {

  cameras: Camera[];

  constructor(private cameraService: CameraService) { }

  ngOnInit() {

    this.getCameras();
  }

  getCameras(): void {
    this.cameraService.getCameras()
      .subscribe(cams => this.cameras = cams);
  }

  getCamerasByName(name: string): void {
    this.cameraService.getCamerasByName(name)
      .subscribe(cams => this.cameras = cams);
  }
}
