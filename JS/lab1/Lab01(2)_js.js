 //Задание 2

 let UserName = 'Alexander';
 let CityName = 'Minsk';
 let Color='#red';
 let UserAnswer = true;
 let Inf = Infinity;
 let number = 532;
 let perimeter = "120mm";
 let UserMessage = "Введенные данные неверны"

//Задание 4

 let SurfaceQuadrilateral = 45 * 21;
 alert(`Площадь четырехугольника: ${SurfaceQuadrilateral}`)

//Задание 5
 let NumberOfSquares = (45/5) * (21%5);
 alert(`Количество квадратов: ${NumberOfSquares}`);

//Задание 6
 let i = 2;
 let a = ++i;
 let b = i++;

 Compare(a,b);

  //Задание 7

 Compare('Привет','привет');
 Compare('Привет','Пока');
 Compare('53',45);
 Compare(false,3);
 Compare(true,"3");
 Compare(3,'5мм');
 Compare(null,undefined);


 function Compare(a,b){
 if(a>b){
     alert(`${a} большe ${b}`);
 }
 else if(a==b){
     alert(`${a} = ${b}`);
 }
 else{
     alert(`${b} большe ${a}`);
 }
 }

  //Задание 8

 alert(UserMessage);

  //Задание 9

 while(1){
 UserChoice= prompt('Да?','');
 if(UserChoice == 'Да'){
     alert("Вы ответили правильно");
     break;
 }
 else{
     alert('Попробуй ещё раз...');
 }
 }

  //Задание 10

 while(1){
     UserLogin = prompt('Логин','');
     UserPassword = prompt('Пароль','');
     if(UserLogin == "student" && UserPassword == "fitfit"){
         alert("Данные введены правильно");
         break;
     }
     else{
         alert('Попробуй ещё раз...');
     }
 }

  //Задание 11 

 ResultMathematic=confirm('Ты сдал математику?');
 ResultRussian=confirm('Ты сдал русский?');
 ResultEnglish=confirm('Ты сдал английский?');
 ResultSum=ResultEnglish + ResultMathematic + ResultRussian;
 if(ResultSum == 3){
     alert('Ты переведён на следующий курс! Поздравляю!!!');
 }
 else if(ResultSum > 0){
     alert('Пересдачи(((');
 }
 else{
     alert('Поздравляю, ты отчислен!!!');
 }

 //Задание 12

 FirstNumber = +prompt('Введите первое число', '1');
 SecondNumber = +prompt('Введите второе число', '2');
 alert(SecondNumber+FirstNumber);

  //Задание 13

alert (true + true);
alert (0 + "5");
alert (5 + "mm");
alert (8/Infinity);
alert (9 * "\n9");
alert (null - 1);
alert ("5" - 2);
alert ("5px" - 3);
alert (true - 3);
alert (7 || 0);

 //Задание 14

for(i=1; i<=10; i++){
    if(i%2==0){
        alert (i+2);
    }
    else{
        alert (`${i}mm`);
    }
}

 //Задание 15

let ChoiceNumber=0;
while(ChoiceNumber < 100){
    ChoiceNumber = +prompt(`Число не больше 100`);  
}

 //Задание 16
 
let Day = +prompt('Введите номер дня недели', '');
switch (Day) {
    case 1:
      alert( 'Понедельник' );
      break;
    case 2:
      alert( 'Вторник' );
      break;
    case 3:
      alert( 'Среда' );
      break;
    case 4:
      alert( 'Четверг' );
      break;
    case 5:
      alert( 'Пятница' );
      break;
    case 6:
      alert( 'Суббота' );
      break;
    case 7:
      alert( 'Воскресенье' );
      break;
    default:
      alert( "Нет  такого(" );
  }