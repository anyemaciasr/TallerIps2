import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'filtroLiquidacion'
})
export class FiltroLiquidacionPipe implements PipeTransform {

  transform(value: any, ...args: any[]): any {
    return null;
  }

}
