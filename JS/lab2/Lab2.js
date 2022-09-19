let Radius = +prompt('Введите радиус круга.');
CircleDiametr(Radius)

function CircleDiametr(Radius){
    let Diameter = 2*Radius;
    alert(`Диаметр круга:${Diameter}`);
}

let Area = (Radius) => 3.14*Radius*Radius
alert(`Площадь круга:${Area(Radius)}`);

Area(Radius);

let Circuit = function (Radius){
    let Circuit = 2 * 3.14* Radius;
    alert(`Длина окружности:${Circuit}`);
}
Circuit(Radius);

//zadanie 2
let OneStr = prompt('Введите строку','');
ThreeString(OneStr,'xq');

function ThreeString(OneStr,TwoStr,ThreeStr = 'cq'){
    let SumStr=OneStr+TwoStr+ThreeStr;
    alert(`Сумма строк равна:${SumStr}`);
}

//zadanie 3
StudentsCount();

function StudentsCount(StudentValue = 0){
    let NameStudent = prompt('Введите имя студента! Если ввели всех, нажмите ОК');
    if(NameStudent == ''){
        alert(`Количество студентов: ${StudentValue}`);
        return;
    }
    else{
        StudentValue++;
    }
    StudentsCount(StudentValue);
}
//zadanie 4

let NumberOfAttempts = 26 ** 5 *10*10;
    let TimeAllAttemptsSeconds = 3* NumberOfAttempts;
    let TimeAllAttemptsMinuts = 0;
    let TimeAllAttemptsHours = 0;
    let TimeAllAttemptsDays = 0;
    let TimeAllAttemptsMounts = 0;
    let TimeAllAttemptsYears = 0;
    while(TimeAllAttemptsSeconds > 60){
    if(TimeAllAttemptsMinuts==60){
    TimeAllAttemptsMinuts = 0;
    TimeAllAttemptsHours++;
    }
    if(TimeAllAttemptsHours == 24){
    TimeAllAttemptsHours = 0;
    TimeAllAttemptsDays++;
    }
    if(TimeAllAttemptsDays == 30){
    TimeAllAttemptsDays = 0;
    TimeAllAttemptsMounts++;
    }
    if(TimeAllAttemptsMounts == 12){
    TimeAllAttemptsMounts = 0;
    TimeAllAttemptsYears++;
    }
    if(TimeAllAttemptsSeconds > 60){
    TimeAllAttemptsSeconds = TimeAllAttemptsSeconds - 60;
    TimeAllAttemptsMinuts++;
    }
    }
    if(TimeAllAttemptsSeconds = 60){
        TimeAllAttemptsSeconds = TimeAllAttemptsSeconds - 60;
        TimeAllAttemptsMinuts++;
        }
    alert(`${TimeAllAttemptsYears} лет ${TimeAllAttemptsMounts} месяцев ${TimeAllAttemptsDays} дней
${TimeAllAttemptsHours} часов ${TimeAllAttemptsMinuts} минут ${TimeAllAttemptsSeconds} секунд`);
    
    //zadanie 5
    
    let StringOrNumber = prompt('Введите значение:','');
let CheckStringOrNumber= + StringOrNumber;
let Choice = 1;
if(isNaN(CheckStringOrNumber) == false){
    Choice = 3;
    if(CheckStringOrNumber > Math.trunc(CheckStringOrNumber)){
        Choice = 2;
    }
}
switch(Choice){
    case 1:{
        alert(StringOrNumber.toUpperCase());
        alert(StringOrNumber.toLowerCase());
        break;
    };
    case 2:{
        StringOrNumber = + StringOrNumber;
        alert(Math.trunc(StringOrNumber+1));
        alert(Math.trunc(StringOrNumber));
        alert(Math.round());
        break;
    }
    case 3:{
        StringOrNumber = + StringOrNumber;
        alert(parseInt(StringOrNumber,16))
        break;
    }
}

    //zadanie 6

let Wort = prompt('Введите словарное слово');
Wort[0].toUpperCase;
let TrueWort = 'Дорога';
for(let i = 0; i<TrueWort.length;i++ )
if(Wort[i]!=TrueWort[i]){
    alert(`Символ ${Wort[i]} неверный`);
    break; //если убрать, показывает все неверные символы
}
else{
    alert('Всё введено верно!');
}
    
  //zadanie


  var kat1 = +prompt("Введите первый катет: ");
  var kat2 = +prompt("Введите второй катет: ");
  triangle(kat1, kat2);
  function triangle(kat1, kat2){
      let hyp = (kat1*kat1+kat2*kat2)**(1/2);
      let square = (kat1*kat2)/2;
      alert (`площадь равна: ${square} `);
      let perimeter = kat1+kat2+hyp;
      alert (`Периметр равен: ${perimeter}`);
      let height = (kat1*kat2*2)/hyp;
      alert (`высота равна: ${height}`);
      let sin = kat1/hyp;
      alert (`sin b: ${sin}`);
      let cos = kat2/hyp;
      alert (`cos b: ${cos}`);
      let tan = kat1/kat2;
      alert (`tan b: ${tan}`);
      let cot = kat2/hyp;
      alert (`cot b: ${cot}`);
      let sin2 = kat2/hyp;
      a
      
      lert (`sin a: ${sin2}`);
      let cos2 = kat1/hyp;
      alert (`cos a: ${cos2}`);
      let tan2 = kat2/kat1;
      alert (`tan a: ${tan2}`);
      let cot2 = kat1/hyp;
      alert (`cot a: ${cot2}`);
      }