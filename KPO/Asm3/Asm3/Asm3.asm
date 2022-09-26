.586P                          ;������� ������ (��������� Pentium)
.MODEL FLAT, STDCALL                  ;������ ������, ���������� � �������
includelib kernel32.lib                  ;������������: ����������� � kernel32

ExitProcess PROTO : DWORD                ;�������� ������� ��� ���������� �������� Windows
MessageBoxA PROTO : DWORD, : DWORD, : DWORD, : DWORD  ;�������� API-������� MessageBoxA (����� � ����)

.STACK 4096                        ;��������� ����� ������� 4 ���������

.DATA                          ;������� ������
  myWords WORD 8Ah, 3Bh, 44h, 5Fh, 99h
  myNumbers dd 2,2,2,0,2,2,2
  str1 dw "AX", 0
  str2 dd "0",


.CODE                          ;������� ����
main PROC                        ;����� ����� main
start:                          ;�����

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
    push 0                      ;��� �������� �������� Windows (�������� ExitProcess)
    call ExitProcess                ;��� ����������� ����� ������� Windows
main ENDP;                      ;����� ���������

end main;