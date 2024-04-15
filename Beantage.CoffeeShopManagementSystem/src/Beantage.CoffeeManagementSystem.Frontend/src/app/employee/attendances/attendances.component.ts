import { DatePipe } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-attendances',
  templateUrl: './attendances.component.html',
  styleUrls: ['./attendances.component.scss']
})

export class AttendancesComponent {
  dateToday = new Date();
  formattedTime = new DatePipe('en-US').transform(this.dateToday, 'hh:mm')!;
  //temporary variable just for test, it should be replaced by a variable from the server once api is connected
  checkedIn = false;
  constructor() {
  }

  formatDate(date : number) : string {
    let currentMonth = new Date().getMonth();
    let currentYear = new Date().getFullYear();
    let currentDate = new Date(currentYear, currentMonth, date);
    return new DatePipe('en-US').transform(currentDate, 'EEE, MMM d')!;
  }

  checkIn() {
    this.checkedIn = true;
  }
  checkOut() {
    this.checkedIn = false;
    alert('Are you shoure you want to check out?');
  }
}
