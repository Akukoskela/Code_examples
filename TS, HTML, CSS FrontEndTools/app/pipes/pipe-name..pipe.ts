import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'pipeName'
})
export class PipeNamePipe implements PipeTransform {

  transform(items: any[], searchText: string): any[] {


    if (!items || !searchText) {
      return items;
    }

    searchText = searchText.toLocaleLowerCase();





    return items.filter(it => {

      return it.Title.toLocaleLowerCase().includes(searchText);

    });
  }

}
