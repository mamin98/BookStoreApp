import { AbstractControl } from '@angular/forms';

export function confirmPassValidator(control: AbstractControl) {
  const password = control.get('password');
  const confirmpassword = control.get('confirmpassword');

  if (password?.pristine || confirmpassword?.pristine) {
    return null;
  } else {
    return password && confirmpassword && password.value !== confirmpassword.value
      ? { misMatch: true }
      : null;
  }
}
