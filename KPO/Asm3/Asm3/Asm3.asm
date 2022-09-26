.586P                          ;система команд (процессор Pentium)
.MODEL FLAT, STDCALL                  ;модель памяти, соглашение о вызовах
includelib kernel32.lib                  ;компановщику: компоновать с kernel32

ExitProcess PROTO : DWORD                ;прототип функции для завершения процесса Windows
MessageBoxA PROTO : DWORD, : DWORD, : DWORD, : DWORD  ;прототип API-функции MessageBoxA (вывод в окно)

.STACK 4096                        ;выделение стека объемом 4 мегабайта

.DATA                          ;сегмент данных
  myWords WORD 8Ah, 3Bh, 44h, 5Fh, 99h
  myNumbers dd 2,2,2,0,2,2,2
  str1 dw "AX", 0
  str2 dd "0",


.CODE                          ;сегмент кода
main PROC                        ;точка входа main
start:                          ;метка

    ;A

   ;mov EDI, 2
   ;mov AX, [myWords + EDI] 
   ;mov BX, myWords[0]
   ;mov str2, BX
   ;mov str2+1, AX 
   ;INVOKE MessageBoxA, 0,offset str2, offset str1, 0

   ;B

   mov EDX, 0
   mov EAX, 0
   mov ECX, 7
   mov EBX, 1
   CYCLE:
   add EAX, myNumbers[EDX]
   add myNumbers[EDX], 0
   jz f1
   add EDX, 4
   loop CYCLE
   jmp fin

   f1:
   mov EBX, 0
   jmp fin
 
   fin:
    push 0                      ;код возврата процесса Windows (параметр ExitProcess)
    call ExitProcess                ;так завершается любой процесс Windows
main ENDP;                      ;конец процедуры

end main;