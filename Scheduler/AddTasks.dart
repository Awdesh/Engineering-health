/* Application intended for users to add their daily health habits
 * User can add their daily health routine task like workout, what they ate. 
 * Web application created in dart programming language.
 * future implementation-: reminders, goal completed in last month/week can be added further.
 * Author- Awdesh Sharma
 */

import 'dart:html';

UListElement
InputElement task 

main(){
  task = querySelector('#task');
  list = querySelector('#list');
  task.onChage.listen(addItem);
}

void addItem(){
  var new = new LIElement();
  newTask.text = task.value;
  task.value = '';
  list.children.add(newTask);
}

