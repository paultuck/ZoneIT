import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'training',
  templateUrl: './training.component.html'
})
export class TrainingComponent {
  public saveStatus: TrainingTrainingCourseSaveStatus;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<TrainingTrainingCourseSaveStatus>(baseUrl + 'api/training').subscribe(result => {
      this.saveStatus = result;
    }, error => console.error(error));
  }
}

interface TrainingTrainingCourseSaveStatus {
  lengthDays: number;
  errorMessage: string;
}
