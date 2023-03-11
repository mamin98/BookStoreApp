import { AbstractControl } from '@angular/forms';

export function confirmPassValidator(control: AbstractControl) {
  const password = control.get('password');
  const confirmPass = control.get('confirmPass');

  if (password?.pristine || confirmPass?.pristine) {
    return null;
  } else {
    return password && confirmPass && password.value !== confirmPass.value
      ? { misMatch: true }
      : null;
  }
}
