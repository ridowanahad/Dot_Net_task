import * as types from '../constants/ActionTypes';
export function loadWebsites(){
  return {
    type: types.LOAD_WEBSITES
  };
}

export function changeVisitDate(visitDate){
  return {
    type: types.VISITDATE_CHANGE,
    visitDate
  };
}
