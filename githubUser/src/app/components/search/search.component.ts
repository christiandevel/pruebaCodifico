import { Component, EventEmitter, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styles: [
  ]
})
export class SearchComponent {

  userForm: FormGroup;
  user: string = '';

  @Output() onEnter: EventEmitter<string> = new EventEmitter();

  constructor(private fb: FormBuilder) {
    this.userForm = this.fb.group({
      userName: ['', Validators.required]
    })
  }


  searchUser() {
    this.user = this.userForm.get('userName')?.value.trim();
    if (this.user.length === 0) {
      this.userForm.get('userName')?.markAsTouched();
      return this.userForm.get('userName')?.setErrors({ required: true })
    }

    this.onEnter.emit(this.user);
  }

}
