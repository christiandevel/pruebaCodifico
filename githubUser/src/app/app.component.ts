import { Component } from '@angular/core';
import { User } from './interface/user.interface';
import { UserService } from './services/user.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'githubUser';

  userName: string = '';
  existError: boolean = false;
  user!: User

  constructor(private service: UserService) { }

  search(user: string) {
    this.existError = false;
    this.userName = user;
    this.service.getInfoUser(this.userName).subscribe((data) => {
      console.log(data);
      this.user = data;
    }, () => {
      this.existError = true;
    })
  }
}
