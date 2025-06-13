import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'removeSpaceBeforeComma'
})
export class RemoveSpaceBeforeCommaPipe implements PipeTransform {

  transform(text: string): string {
if (!text) return '';
    // מחליף רווחים לפני פסיק בפסיק בלבד
    return text.replace(/\s+,/g, ',');  }

}
