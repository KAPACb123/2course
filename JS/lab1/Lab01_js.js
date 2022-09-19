number=prompt("number?",'');
gradeNumber=prompt("grade?",'');

if(gradeNumber<0) {
    alert(`Степень ${gradeNumber} не поддерживается, введите целую степень, большую 0`);
}
else {
    alert(Exponentiate(number,gradeNumber));
}

function Exponentiate(number,gradeNumber) {
    let result=1;

    for (var i=0; i<gradeNumber; i++) {
        result*=number;
    }
    
    return result;
}