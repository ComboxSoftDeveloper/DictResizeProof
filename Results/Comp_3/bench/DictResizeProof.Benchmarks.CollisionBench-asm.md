## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFDF2A4FE40]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,rdx
       xor       edi,edi
       xor       ebp,ebp
       jmp       short M01_L06
M01_L00:
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       rdx,[r11]
       xor       r8,rdx
       xor       rcx,[r11+2]
       or        rcx,r8
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
M01_L01:
       mov       ecx,eax
       jmp       short M01_L04
M01_L02:
       xor       ecx,ecx
       jmp       short M01_L04
M01_L03:
       mov       ecx,1
M01_L04:
       test      ecx,ecx
       je        near ptr M01_L12
       add       r12,10
       test      r12,r12
       je        short M01_L05
       inc       edi
M01_L05:
       inc       ebp
M01_L06:
       cmp       [rsi+8],ebp
       jle       near ptr M01_L15
       mov       r14,[rsi+rbp*8+10]
       cmp       [rbx],bl
       test      r14,r14
       je        near ptr M01_L18
       cmp       qword ptr [rbx+8],0
       je        short M01_L05
       mov       r15,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L16
       lea       rcx,[r14+0C]
       mov       [rsp+38],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rsp+38]
       mov       eax,[r14+8]
       cmp       eax,2
       jle       short M01_L08
M01_L07:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[r11]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[r11+4]
       add       r11,8
       cmp       eax,2
       jg        short M01_L07
M01_L08:
       test      eax,eax
       jle       short M01_L09
       mov       eax,edx
       rol       eax,5
       add       eax,edx
       mov       edx,eax
       xor       edx,[r11]
M01_L09:
       imul      r13d,edx,5D588B65
       add       r13d,ecx
       xor       ecx,ecx
       mov       [rsp+38],rcx
M01_L10:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       eax,r8d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M01_L19
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r12d,[rcx]
       mov       rax,[rbx+10]
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       [rsp+44],r10d
       dec       r12d
       mov       r9d,[rax+8]
       mov       [rsp+34],r9d
       cmp       r9d,r12d
       jbe       near ptr M01_L05
M01_L11:
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[rax+rcx*8+10]
       cmp       [r12+8],r13d
       je        short M01_L13
M01_L12:
       mov       r12d,[r12+0C]
       mov       r10d,[rsp+44]
       inc       r10d
       mov       r9d,[rsp+34]
       cmp       r9d,r10d
       jb        short M01_L14
       cmp       r9d,r12d
       mov       [rsp+44],r10d
       mov       rax,[rsp+28]
       jbe       near ptr M01_L05
       jmp       short M01_L11
M01_L13:
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L17
       cmp       rdx,r14
       je        near ptr M01_L03
       test      rdx,rdx
       je        near ptr M01_L02
       mov       ecx,[rdx+8]
       cmp       ecx,[r14+8]
       jne       near ptr M01_L02
       lea       rcx,[rdx+0C]
       lea       r11,[r14+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       je        near ptr M01_L00
       mov       rdx,r11
       call      qword ptr [7FFDF267C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L01
M01_L14:
       call      qword ptr [7FFDF267F480]
       int       3
M01_L15:
       mov       eax,edi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L16:
       mov       rcx,r15
       mov       rdx,r14
       mov       r11,7FFDF25C04C0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L10
M01_L17:
       mov       rcx,r15
       mov       r8,r14
       mov       r11,7FFDF25C04C8
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M01_L04
M01_L18:
       mov       ecx,4
       call      qword ptr [7FFDF267FD38]
       int       3
M01_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 602
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFDC8DA7E28]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M01_L02
       cmp       [rsi],sil
M01_L00:
       mov       ecx,ebp
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,rsi
       call      qword ptr [7FFDC8C3E9E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L03
M01_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M01_L00
M01_L02:
       mov       eax,edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       inc       edi
       jmp       short M01_L01
; Total bytes of code 77
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L09
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L08
       mov       rdi,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+40]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFDC8EA2400
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L01:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rbx+8]
       mov       edx,ebp
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M02_L11
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
M02_L02:
       mov       r12d,[r15+8]
       cmp       r12d,r14d
       jbe       short M02_L08
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r14,[r15+rcx*8+10]
       cmp       [r14+8],ebp
       je        short M02_L04
M02_L03:
       mov       r14d,[r14+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        short M02_L10
       jmp       short M02_L02
M02_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFDC8EA2418
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rdx,[r14]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L03
       lea       rax,[r14+10]
M02_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L08:
       xor       eax,eax
       jmp       short M02_L07
M02_L09:
       mov       ecx,4
       call      qword ptr [7FFDC8BDED00]
       int       3
M02_L10:
       call      qword ptr [7FFDC8BDF030]
       int       3
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 304
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFD5291F000]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       mov       edi,[rdx+8]
       test      edi,edi
       jle       short M01_L02
       cmp       [rbx],bl
       lea       rbp,[rdx+10]
M01_L00:
       mov       rdx,[rbp]
       mov       rcx,rbx
       call      qword ptr [7FFD5291F030]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       inc       esi
M01_L01:
       add       rbp,8
       dec       edi
       jne       short M01_L00
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 65
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L10
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L09
       mov       rdi,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L03
M02_L00:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rbx+8]
       mov       edx,ebp
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M02_L11
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ecx
M02_L01:
       mov       r13d,[r14+8]
       cmp       r13d,ecx
       jbe       near ptr M02_L09
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],ebp
       je        short M02_L04
M02_L02:
       mov       ecx,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       short M02_L01
       jmp       short M02_L08
M02_L03:
       mov       rdx,7FFD52998498
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M02_L00
M02_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+50]
       test      r11,r11
       je        short M02_L07
M02_L05:
       mov       rdx,[r12]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
       lea       rax,[r12+10]
M02_L06:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L07:
       mov       rdx,7FFD529984B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M02_L05
M02_L08:
       call      qword ptr [7FFD5254F390]
       int       3
M02_L09:
       xor       eax,eax
       jmp       short M02_L06
M02_L10:
       mov       ecx,4
       call      qword ptr [7FFD5254FC18]
       int       3
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 315
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFDF2A7FD68]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,rdx
       xor       edi,edi
       xor       ebp,ebp
       cmp       [rsi+8],ebp
       jg        short M01_L04
M01_L00:
       mov       eax,edi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       mov       ecx,1
M01_L02:
       test      ecx,ecx
       je        near ptr M01_L10
       add       r12,10
       test      r12,r12
       je        short M01_L03
       inc       edi
M01_L03:
       inc       ebp
       cmp       [rsi+8],ebp
       jle       short M01_L00
M01_L04:
       mov       r14,[rsi+rbp*8+10]
       cmp       [rbx],bl
       test      r14,r14
       je        near ptr M01_L17
       cmp       qword ptr [rbx+8],0
       je        short M01_L03
       mov       r15,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L15
       lea       rcx,[r14+0C]
       mov       [rsp+38],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rsp+38]
       mov       eax,[r14+8]
       cmp       eax,2
       jle       short M01_L06
M01_L05:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[r11]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[r11+4]
       add       r11,8
       cmp       eax,2
       jg        short M01_L05
M01_L06:
       test      eax,eax
       jle       short M01_L07
       mov       eax,edx
       rol       eax,5
       add       eax,edx
       mov       edx,eax
       xor       edx,[r11]
M01_L07:
       imul      r13d,edx,5D588B65
       add       r13d,ecx
       xor       ecx,ecx
       mov       [rsp+38],rcx
M01_L08:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       eax,r8d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M01_L19
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r12d,[rcx]
       mov       rax,[rbx+10]
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       [rsp+44],r10d
       dec       r12d
       mov       r9d,[rax+8]
       mov       [rsp+34],r9d
       cmp       r9d,r12d
       jbe       near ptr M01_L03
M01_L09:
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[rax+rcx*8+10]
       cmp       [r12+8],r13d
       je        short M01_L11
M01_L10:
       mov       r12d,[r12+0C]
       mov       r10d,[rsp+44]
       inc       r10d
       mov       r9d,[rsp+34]
       cmp       r9d,r10d
       jb        near ptr M01_L18
       cmp       r9d,r12d
       mov       [rsp+44],r10d
       mov       rax,[rsp+28]
       jbe       near ptr M01_L03
       jmp       short M01_L09
M01_L11:
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L16
       cmp       rdx,r14
       je        near ptr M01_L01
       test      rdx,rdx
       je        short M01_L14
       mov       ecx,[rdx+8]
       cmp       ecx,[r14+8]
       jne       short M01_L14
       lea       rcx,[rdx+0C]
       lea       r11,[r14+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       je        short M01_L12
       mov       rdx,r11
       call      qword ptr [7FFDF26AC330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L13
M01_L12:
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       rdx,[r11]
       xor       r8,rdx
       xor       rcx,[r11+2]
       or        rcx,r8
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
M01_L13:
       mov       ecx,eax
       jmp       near ptr M01_L02
M01_L14:
       xor       ecx,ecx
       jmp       near ptr M01_L02
M01_L15:
       mov       rcx,r15
       mov       rdx,r14
       mov       r11,7FFDF25F04C0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L08
M01_L16:
       mov       rcx,r15
       mov       r8,r14
       mov       r11,7FFDF25F04C8
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M01_L02
M01_L17:
       mov       ecx,4
       call      qword ptr [7FFDF26AFD38]
       int       3
M01_L18:
       call      qword ptr [7FFDF26AF480]
       int       3
M01_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 596
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFDC8DD7E28]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M01_L02
       cmp       [rsi],sil
M01_L00:
       mov       ecx,ebp
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,rsi
       call      qword ptr [7FFDC8C6E9E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       inc       edi
M01_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M01_L00
M01_L02:
       mov       eax,edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 75
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L09
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L08
       mov       rdi,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+40]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFDC8ED2400
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L01:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rbx+8]
       mov       edx,ebp
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M02_L11
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
M02_L02:
       mov       r12d,[r15+8]
       cmp       r12d,r14d
       jbe       short M02_L08
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r14,[r15+rcx*8+10]
       cmp       [r14+8],ebp
       je        short M02_L04
M02_L03:
       mov       r14d,[r14+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        short M02_L10
       jmp       short M02_L02
M02_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rdx,7FFDC8ED2418
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L06:
       mov       rdx,[r14]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L03
       lea       rax,[r14+10]
M02_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L08:
       xor       eax,eax
       jmp       short M02_L07
M02_L09:
       mov       ecx,4
       call      qword ptr [7FFDC8C0ED00]
       int       3
M02_L10:
       call      qword ptr [7FFDC8C0F030]
       int       3
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 304
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFD528EF018]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       mov       edi,[rdx+8]
       test      edi,edi
       jle       short M01_L02
       cmp       [rbx],bl
       lea       rbp,[rdx+10]
M01_L00:
       mov       rdx,[rbp]
       mov       rcx,rbx
       call      qword ptr [7FFD528EF048]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       inc       esi
M01_L01:
       add       rbp,8
       dec       edi
       jne       short M01_L00
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 65
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L10
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L09
       mov       rdi,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L03
M02_L00:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rbx+8]
       mov       edx,ebp
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M02_L11
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       ecx,[rcx]
       mov       r14,[rbx+10]
       xor       r15d,r15d
       dec       ecx
M02_L01:
       mov       r13d,[r14+8]
       cmp       r13d,ecx
       jbe       near ptr M02_L09
       mov       ecx,ecx
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r14+rcx*8+10]
       cmp       [r12+8],ebp
       je        short M02_L04
M02_L02:
       mov       ecx,[r12+0C]
       inc       r15d
       cmp       r13d,r15d
       jae       short M02_L01
       jmp       short M02_L08
M02_L03:
       mov       rdx,7FFD529684F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M02_L00
M02_L04:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+50]
       test      r11,r11
       je        short M02_L07
M02_L05:
       mov       rdx,[r12]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L02
       lea       rax,[r12+10]
M02_L06:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L07:
       mov       rdx,7FFD52968508
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M02_L05
M02_L08:
       call      qword ptr [7FFD5251F390]
       int       3
M02_L09:
       xor       eax,eax
       jmp       short M02_L06
M02_L10:
       mov       ecx,4
       call      qword ptr [7FFD5251FC18]
       int       3
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 315
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFDF2A3FDF8]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rsi,rdx
       xor       edi,edi
       xor       ebp,ebp
       jmp       near ptr M01_L09
M01_L00:
       cmp       edx,4
       jb        near ptr M01_L16
M01_L01:
       add       r11d,[rcx]
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
M01_L02:
       mov       r8d,edx
       and       r8,7
       mov       ecx,[rcx+r8-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L03:
       add       ecx,r11d
       mov       edx,eax
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,edx
       rol       edx,9
       xor       edx,r13d
       rol       r13d,1B
       add       r13d,edx
       mov       r12d,edx
       rol       r12d,13
       xor       r13d,r12d
M01_L04:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       eax,r8d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M01_L32
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r12d,[rcx]
       mov       rax,[rbx+10]
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       [rsp+34],r10d
       dec       r12d
       cmp       [rax+8],r12d
       jbe       short M01_L08
       mov       rcx,offset MT_System.Collections.Generic.RandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L12
M01_L05:
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[rax+rcx*8+10]
       cmp       [r15+8],r13d
       jne       near ptr M01_L11
       mov       rdx,[r15]
       cmp       rdx,r14
       jne       near ptr M01_L20
       mov       r12d,1
M01_L06:
       test      r12d,r12d
       je        near ptr M01_L11
M01_L07:
       add       r15,10
       test      r15,r15
       je        short M01_L08
       inc       edi
M01_L08:
       inc       ebp
M01_L09:
       cmp       [rsi+8],ebp
       jle       near ptr M01_L15
       mov       r14,[rsi+rbp*8+10]
       cmp       [rbx],bl
       test      r14,r14
       je        near ptr M01_L31
       cmp       qword ptr [rbx+8],0
       je        short M01_L08
       mov       r15,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.RandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L19
       lea       rcx,[r14+0C]
       mov       edx,[r14+8]
       add       edx,edx
       mov       r11d,[r15+10]
       mov       eax,[r15+14]
       cmp       edx,8
       jb        near ptr M01_L00
       mov       r8d,edx
       shr       r8d,3
M01_L10:
       add       r11d,[rcx]
       mov       r10d,[rcx+4]
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       add       r10d,r11d
       mov       r11d,eax
       xor       r11d,r10d
       rol       r10d,14
       add       r10d,r11d
       rol       r11d,9
       xor       r11d,r10d
       rol       r10d,1B
       add       r10d,r11d
       rol       r11d,13
       mov       eax,r10d
       add       rcx,8
       dec       r8d
       mov       r9d,eax
       mov       eax,r11d
       mov       r11d,r9d
       jne       short M01_L10
       test      dl,4
       je        near ptr M01_L02
       jmp       near ptr M01_L01
M01_L11:
       mov       r12d,[r15+0C]
       mov       r10d,[rsp+34]
       inc       r10d
       mov       rax,[rsp+28]
       mov       [rsp+34],r10d
       cmp       [rax+8],r10d
       jb        short M01_L14
       cmp       [rax+8],r12d
       jbe       near ptr M01_L08
       jmp       near ptr M01_L05
M01_L12:
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rax+rcx*8+10]
       mov       r12,rcx
       cmp       [r12+8],r13d
       jne       near ptr M01_L30
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.RandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L25
       cmp       rdx,r14
       jne       near ptr M01_L26
       mov       r9d,1
M01_L13:
       test      r9d,r9d
       je        near ptr M01_L30
       mov       r15,r12
       jmp       near ptr M01_L07
M01_L14:
       call      qword ptr [7FFDF266F480]
       int       3
M01_L15:
       mov       eax,edi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L16:
       mov       r8d,80
       test      dl,1
       je        short M01_L17
       mov       r8d,edx
       and       r8,2
       movzx     r8d,byte ptr [rcx+r8]
       or        r8d,8000
M01_L17:
       test      dl,2
       je        short M01_L18
       shl       r8d,10
       movzx     ecx,word ptr [rcx]
       or        r8d,ecx
       mov       ecx,r8d
       jmp       near ptr M01_L03
M01_L18:
       mov       ecx,r8d
       jmp       near ptr M01_L03
M01_L19:
       mov       rcx,r15
       mov       rdx,r14
       mov       r11,7FFDF25B04C8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L04
M01_L20:
       test      rdx,rdx
       je        short M01_L21
       mov       ecx,[rdx+8]
       cmp       ecx,[r14+8]
       je        short M01_L22
M01_L21:
       xor       r12d,r12d
       jmp       near ptr M01_L06
M01_L22:
       lea       rcx,[rdx+0C]
       lea       r9,[r14+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       jne       short M01_L23
       mov       rdx,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[r9]
       xor       rdx,r8
       xor       rcx,[r9+2]
       or        rcx,rdx
       sete      r12b
       movzx     r12d,r12b
       jmp       short M01_L24
M01_L23:
       mov       rdx,r9
       call      qword ptr [7FFDF266C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r12d,eax
M01_L24:
       jmp       near ptr M01_L06
M01_L25:
       mov       rcx,r15
       mov       r8,r14
       mov       r11,7FFDF25B04D0
       call      qword ptr [r11]
       mov       r9d,eax
       jmp       near ptr M01_L13
M01_L26:
       test      rdx,rdx
       je        short M01_L29
       mov       ecx,[rdx+8]
       cmp       ecx,[r14+8]
       jne       short M01_L29
       lea       rcx,[rdx+0C]
       lea       r9,[r14+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       je        short M01_L27
       mov       rdx,r9
       call      qword ptr [7FFDF266C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r9d,eax
       jmp       short M01_L28
M01_L27:
       mov       r8,r9
       mov       rdx,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[r8]
       xor       rdx,r11
       xor       rcx,[r8+2]
       or        rcx,rdx
       sete      r9b
       movzx     r9d,r9b
M01_L28:
       jmp       near ptr M01_L13
M01_L29:
       xor       r9d,r9d
       jmp       near ptr M01_L13
M01_L30:
       mov       r12d,[r12+0C]
       mov       r10d,[rsp+34]
       inc       r10d
       mov       rax,[rsp+28]
       cmp       [rax+8],r10d
       jb        near ptr M01_L14
       cmp       [rax+8],r12d
       mov       [rsp+34],r10d
       jbe       near ptr M01_L08
       jmp       near ptr M01_L12
M01_L31:
       mov       ecx,4
       call      qword ptr [7FFDF266FD38]
       int       3
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1027
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFDC8DA7E28]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M01_L02
       cmp       [rsi],sil
M01_L00:
       mov       ecx,ebp
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,rsi
       call      qword ptr [7FFDC8C3E9E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L03
M01_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M01_L00
M01_L02:
       mov       eax,edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       inc       edi
       jmp       short M01_L01
; Total bytes of code 77
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L08
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L07
       mov       rdi,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+40]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,offset System.Runtime.InteropServices.MemoryMarshal.GetArrayDataReference[[BenchmarkDotNet.Reports.Measurement, BenchmarkDotNet]](BenchmarkDotNet.Reports.Measurement[])
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L01:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rbx+8]
       mov       edx,ebp
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M02_L10
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
M02_L02:
       mov       r12d,[r15+8]
       cmp       r12d,r14d
       jbe       short M02_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r14,[r15+rcx*8+10]
       cmp       [r14+8],ebp
       jne       short M02_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFDC8EA2740
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L04:
       mov       rdx,[r14]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
       lea       rax,[r14+10]
M02_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       r14d,[r14+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        short M02_L09
       jmp       short M02_L02
M02_L07:
       xor       eax,eax
       jmp       short M02_L05
M02_L08:
       mov       ecx,4
       call      qword ptr [7FFDC8BDED00]
       int       3
M02_L09:
       call      qword ptr [7FFDC8BDF030]
       int       3
M02_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 304
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFD93CBF090]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       mov       edi,[rdx+8]
       test      edi,edi
       jle       short M01_L02
       cmp       [rbx],bl
       lea       rbp,[rdx+10]
M01_L00:
       mov       rdx,[rbp]
       mov       rcx,rbx
       call      qword ptr [7FFD93CBF0C0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       inc       esi
M01_L01:
       add       rbp,8
       dec       edi
       jne       short M01_L00
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 65
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L09
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L07
       mov       rdi,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        near ptr M02_L04
M02_L00:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rbx+8]
       mov       edx,ebp
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M02_L10
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r14d,[rcx]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
M02_L01:
       mov       r12d,[r15+8]
       cmp       r12d,r14d
       jbe       near ptr M02_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r14,[r15+rcx*8+10]
       cmp       [r14+8],ebp
       jne       short M02_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+68]
       test      r11,r11
       je        short M02_L05
M02_L02:
       mov       rdx,[r14]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
       lea       rax,[r14+10]
M02_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rdx,7FFD93D38648
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M02_L00
M02_L05:
       mov       rdx,7FFD93D38660
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M02_L02
M02_L06:
       mov       r14d,[r14+0C]
       inc       r13d
       cmp       r12d,r13d
       jae       near ptr M02_L01
       jmp       short M02_L08
M02_L07:
       xor       eax,eax
       jmp       short M02_L03
M02_L08:
       call      qword ptr [7FFD938EF390]
       int       3
M02_L09:
       mov       ecx,4
       call      qword ptr [7FFD938EFC18]
       int       3
M02_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 322
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFDF2A4FDF8]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rsi,rdx
       xor       edi,edi
       xor       ebp,ebp
       cmp       [rsi+8],ebp
       jg        short M01_L06
M01_L00:
       mov       eax,edi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       cmp       edx,4
       jb        near ptr M01_L18
       jmp       near ptr M01_L08
M01_L02:
       mov       rdx,[r15]
       cmp       rdx,r14
       jne       near ptr M01_L22
       mov       r12d,1
M01_L03:
       test      r12d,r12d
       je        near ptr M01_L13
M01_L04:
       add       r15,10
       test      r15,r15
       je        short M01_L05
       inc       edi
M01_L05:
       inc       ebp
       cmp       [rsi+8],ebp
       jle       short M01_L00
M01_L06:
       mov       r14,[rsi+rbp*8+10]
       cmp       [rbx],bl
       test      r14,r14
       je        near ptr M01_L32
       cmp       qword ptr [rbx+8],0
       je        short M01_L05
       mov       r15,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.RandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L21
       lea       rcx,[r14+0C]
       mov       edx,[r14+8]
       add       edx,edx
       mov       r11d,[r15+10]
       mov       eax,[r15+14]
       cmp       edx,8
       jb        short M01_L01
       mov       r8d,edx
       shr       r8d,3
M01_L07:
       add       r11d,[rcx]
       mov       r10d,[rcx+4]
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
       add       r10d,r11d
       mov       r11d,eax
       xor       r11d,r10d
       rol       r10d,14
       add       r10d,r11d
       rol       r11d,9
       xor       r11d,r10d
       rol       r10d,1B
       add       r10d,r11d
       rol       r11d,13
       mov       eax,r10d
       add       rcx,8
       dec       r8d
       mov       r9d,eax
       mov       eax,r11d
       mov       r11d,r9d
       jne       short M01_L07
       test      dl,4
       je        short M01_L09
M01_L08:
       add       r11d,[rcx]
       xor       eax,r11d
       rol       r11d,14
       add       r11d,eax
       rol       eax,9
       xor       eax,r11d
       rol       r11d,1B
       add       r11d,eax
       rol       eax,13
M01_L09:
       mov       r8d,edx
       and       r8,7
       mov       ecx,[rcx+r8-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M01_L10:
       add       ecx,r11d
       mov       edx,eax
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       r13d,ecx
       rol       r13d,14
       add       r13d,edx
       rol       edx,9
       xor       edx,r13d
       rol       r13d,1B
       add       r13d,edx
       mov       r12d,edx
       rol       r12d,13
       xor       r13d,r12d
M01_L11:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       eax,r8d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M01_L33
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r12d,[rcx]
       mov       rax,[rbx+10]
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       [rsp+34],r10d
       dec       r12d
       cmp       [rax+8],r12d
       jbe       near ptr M01_L05
       mov       rcx,offset MT_System.Collections.Generic.RandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       short M01_L15
M01_L12:
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[rax+rcx*8+10]
       cmp       [r15+8],r13d
       je        near ptr M01_L02
M01_L13:
       mov       r12d,[r15+0C]
       mov       r10d,[rsp+34]
       inc       r10d
       mov       rax,[rsp+28]
       mov       [rsp+34],r10d
       cmp       [rax+8],r10d
       jb        near ptr M01_L17
       cmp       [rax+8],r12d
       jbe       near ptr M01_L05
       jmp       short M01_L12
M01_L14:
       mov       r12d,[r12+0C]
       mov       r10d,[rsp+34]
       inc       r10d
       mov       rax,[rsp+28]
       cmp       [rax+8],r10d
       jb        short M01_L17
       cmp       [rax+8],r12d
       mov       [rsp+34],r10d
       jbe       near ptr M01_L05
M01_L15:
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rax+rcx*8+10]
       mov       r12,rcx
       cmp       [r12+8],r13d
       jne       short M01_L14
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.RandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L27
       cmp       rdx,r14
       jne       near ptr M01_L28
       mov       r9d,1
M01_L16:
       test      r9d,r9d
       je        short M01_L14
       mov       r15,r12
       jmp       near ptr M01_L04
M01_L17:
       call      qword ptr [7FFDF267F480]
       int       3
M01_L18:
       mov       r8d,80
       test      dl,1
       je        short M01_L19
       mov       r8d,edx
       and       r8,2
       movzx     r8d,byte ptr [rcx+r8]
       or        r8d,8000
M01_L19:
       test      dl,2
       je        short M01_L20
       shl       r8d,10
       movzx     ecx,word ptr [rcx]
       or        r8d,ecx
       mov       ecx,r8d
       jmp       near ptr M01_L10
M01_L20:
       mov       ecx,r8d
       jmp       near ptr M01_L10
M01_L21:
       mov       rcx,r15
       mov       rdx,r14
       mov       r11,7FFDF25C04C8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L11
M01_L22:
       test      rdx,rdx
       je        short M01_L23
       mov       ecx,[rdx+8]
       cmp       ecx,[r14+8]
       je        short M01_L24
M01_L23:
       xor       r12d,r12d
       jmp       near ptr M01_L03
M01_L24:
       lea       rcx,[rdx+0C]
       lea       r9,[r14+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       jne       short M01_L25
       mov       rdx,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[r9]
       xor       rdx,r8
       xor       rcx,[r9+2]
       or        rcx,rdx
       sete      r12b
       movzx     r12d,r12b
       jmp       short M01_L26
M01_L25:
       mov       rdx,r9
       call      qword ptr [7FFDF267C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r12d,eax
M01_L26:
       jmp       near ptr M01_L03
M01_L27:
       mov       rcx,r15
       mov       r8,r14
       mov       r11,7FFDF25C04D0
       call      qword ptr [r11]
       mov       r9d,eax
       jmp       near ptr M01_L16
M01_L28:
       test      rdx,rdx
       je        short M01_L31
       mov       ecx,[rdx+8]
       cmp       ecx,[r14+8]
       jne       short M01_L31
       lea       rcx,[rdx+0C]
       lea       r9,[r14+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       je        short M01_L29
       mov       rdx,r9
       call      qword ptr [7FFDF267C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r9d,eax
       jmp       short M01_L30
M01_L29:
       mov       r8,r9
       mov       rdx,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[r8]
       xor       rdx,r11
       xor       rcx,[r8+2]
       or        rcx,rdx
       sete      r9b
       movzx     r9d,r9b
M01_L30:
       jmp       near ptr M01_L16
M01_L31:
       xor       r9d,r9d
       jmp       near ptr M01_L16
M01_L32:
       mov       ecx,4
       call      qword ptr [7FFDF267FD38]
       int       3
M01_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 999
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFDC8DA7E28]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M01_L02
       cmp       [rsi],sil
M01_L00:
       mov       ecx,ebp
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,rsi
       call      qword ptr [7FFDC8C3E9E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       inc       edi
M01_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M01_L00
M01_L02:
       mov       eax,edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 75
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L08
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L07
       mov       rdi,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+40]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFDC8EA2728
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L01:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rbx+8]
       mov       edx,ebp
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M02_L10
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
M02_L02:
       mov       r12d,[r15+8]
       cmp       r12d,r14d
       jbe       short M02_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r14,[r15+rcx*8+10]
       cmp       [r14+8],ebp
       jne       short M02_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFDC8EA2740
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L04:
       mov       rdx,[r14]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
       lea       rax,[r14+10]
M02_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       r14d,[r14+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        short M02_L09
       jmp       short M02_L02
M02_L07:
       xor       eax,eax
       jmp       short M02_L05
M02_L08:
       mov       ecx,4
       call      qword ptr [7FFDC8BDED00]
       int       3
M02_L09:
       call      qword ptr [7FFDC8BDF030]
       int       3
M02_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 304
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFD93CBF090]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       mov       edi,[rdx+8]
       test      edi,edi
       jle       short M01_L02
       cmp       [rbx],bl
       lea       rbp,[rdx+10]
M01_L00:
       mov       rdx,[rbp]
       mov       rcx,rbx
       call      qword ptr [7FFD93CBF0C0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       inc       esi
M01_L01:
       add       rbp,8
       dec       edi
       jne       short M01_L00
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 65
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L09
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L07
       mov       rdi,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+60]
       test      r11,r11
       je        near ptr M02_L04
M02_L00:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rbx+8]
       mov       edx,ebp
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M02_L10
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r14d,[rcx]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
M02_L01:
       mov       r12d,[r15+8]
       cmp       r12d,r14d
       jbe       near ptr M02_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r14,[r15+rcx*8+10]
       cmp       [r14+8],ebp
       jne       short M02_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+68]
       test      r11,r11
       je        short M02_L05
M02_L02:
       mov       rdx,[r14]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
       lea       rax,[r14+10]
M02_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rdx,7FFD93D38648
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M02_L00
M02_L05:
       mov       rdx,7FFD93D38660
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M02_L02
M02_L06:
       mov       r14d,[r14+0C]
       inc       r13d
       cmp       r12d,r13d
       jae       near ptr M02_L01
       jmp       short M02_L08
M02_L07:
       xor       eax,eax
       jmp       short M02_L03
M02_L08:
       call      qword ptr [7FFD938EF390]
       int       3
M02_L09:
       mov       ecx,4
       call      qword ptr [7FFD938EFC18]
       int       3
M02_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 322
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFDF2A6FAF8]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,rdx
       xor       edi,edi
       xor       ebp,ebp
       jmp       short M01_L07
M01_L00:
       mov       rdx,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[r9]
       xor       rdx,r8
       xor       rcx,[r9+2]
       or        rcx,rdx
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
M01_L01:
       mov       ecx,eax
       jmp       short M01_L04
M01_L02:
       xor       ecx,ecx
       jmp       short M01_L04
M01_L03:
       mov       ecx,1
M01_L04:
       test      ecx,ecx
       je        near ptr M01_L13
M01_L05:
       add       r15,10
       test      r15,r15
       je        short M01_L06
       inc       edi
M01_L06:
       inc       ebp
M01_L07:
       cmp       [rsi+8],ebp
       jle       near ptr M01_L22
       mov       r14,[rsi+rbp*8+10]
       cmp       [rbx],bl
       test      r14,r14
       je        near ptr M01_L25
       cmp       qword ptr [rbx+8],0
       je        short M01_L06
       mov       r15,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L23
       lea       rcx,[r14+0C]
       mov       [rsp+28],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rsp+28]
       mov       eax,[r14+8]
       cmp       eax,2
       jle       short M01_L09
M01_L08:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[r11]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[r11+4]
       add       r11,8
       cmp       eax,2
       jg        short M01_L08
M01_L09:
       test      eax,eax
       jle       short M01_L10
       mov       eax,edx
       rol       eax,5
       add       eax,edx
       mov       edx,eax
       xor       edx,[r11]
M01_L10:
       imul      r13d,edx,5D588B65
       add       r13d,ecx
       xor       ecx,ecx
       mov       [rsp+28],rcx
M01_L11:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       eax,r8d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M01_L26
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r12d,[rcx]
       mov       rax,[rbx+10]
       mov       [rsp+20],rax
       xor       r10d,r10d
       mov       [rsp+34],r10d
       dec       r12d
       cmp       [rax+8],r12d
       jbe       near ptr M01_L06
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L20
M01_L12:
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[rax+rcx*8+10]
       cmp       [r15+8],r13d
       jne       short M01_L13
       mov       rdx,[r15]
       cmp       rdx,r14
       je        near ptr M01_L03
       test      rdx,rdx
       je        near ptr M01_L02
       mov       ecx,[rdx+8]
       cmp       ecx,[r14+8]
       jne       near ptr M01_L02
       lea       rcx,[rdx+0C]
       lea       r9,[r14+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       je        near ptr M01_L00
       mov       rdx,r9
       call      qword ptr [7FFDF269C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L01
M01_L13:
       mov       r12d,[r15+0C]
       mov       r10d,[rsp+34]
       inc       r10d
       mov       rax,[rsp+20]
       mov       [rsp+34],r10d
       cmp       [rax+8],r10d
       jb        near ptr M01_L21
       cmp       [rax+8],r12d
       jbe       near ptr M01_L06
       jmp       near ptr M01_L12
M01_L14:
       mov       r8,r9
       mov       rdx,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[r8]
       xor       rdx,r11
       xor       rcx,[r8+2]
       or        rcx,rdx
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
M01_L15:
       mov       ecx,eax
       jmp       short M01_L18
M01_L16:
       xor       ecx,ecx
       jmp       short M01_L18
M01_L17:
       mov       ecx,1
M01_L18:
       test      ecx,ecx
       je        short M01_L19
       mov       r15,r12
       jmp       near ptr M01_L05
M01_L19:
       mov       r12d,[r12+0C]
       mov       r10d,[rsp+34]
       inc       r10d
       mov       rax,[rsp+20]
       cmp       [rax+8],r10d
       jb        short M01_L21
       cmp       [rax+8],r12d
       mov       [rsp+34],r10d
       jbe       near ptr M01_L06
M01_L20:
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rax+rcx*8+10]
       mov       r12,rcx
       cmp       [r12+8],r13d
       jne       short M01_L19
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       short M01_L24
       cmp       rdx,r14
       je        short M01_L17
       test      rdx,rdx
       je        short M01_L16
       mov       ecx,[rdx+8]
       cmp       ecx,[r14+8]
       jne       short M01_L16
       lea       rcx,[rdx+0C]
       lea       r9,[r14+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       je        near ptr M01_L14
       mov       rdx,r9
       call      qword ptr [7FFDF269C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L15
M01_L21:
       call      qword ptr [7FFDF269F480]
       int       3
M01_L22:
       mov       eax,edi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L23:
       mov       rcx,r15
       mov       rdx,r14
       mov       r11,7FFDF25E04C0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L11
M01_L24:
       mov       rcx,r15
       mov       r8,r14
       mov       r11,7FFDF25E04C8
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M01_L18
M01_L25:
       mov       ecx,4
       call      qword ptr [7FFDF269FD38]
       int       3
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 790
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFDC8DA7E28]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M01_L02
       cmp       [rsi],sil
M01_L00:
       mov       ecx,ebp
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,rsi
       call      qword ptr [7FFDC8C3E9E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L03
M01_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M01_L00
M01_L02:
       mov       eax,edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       inc       edi
       jmp       short M01_L01
; Total bytes of code 77
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L08
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L07
       mov       rdi,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+40]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFDC8E3E2D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L01:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rbx+8]
       mov       edx,ebp
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M02_L10
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
M02_L02:
       mov       r12d,[r15+8]
       cmp       r12d,r14d
       jbe       short M02_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r14,[r15+rcx*8+10]
       cmp       [r14+8],ebp
       jne       short M02_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFDC8E3E2E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L04:
       mov       rdx,[r14]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
       lea       rax,[r14+10]
M02_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       r14d,[r14+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        short M02_L09
       jmp       short M02_L02
M02_L07:
       xor       eax,eax
       jmp       short M02_L05
M02_L08:
       mov       ecx,4
       call      qword ptr [7FFDC8BDED00]
       int       3
M02_L09:
       call      qword ptr [7FFDC8BDF030]
       int       3
M02_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 304
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFD93C6EE50]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       mov       edi,[rdx+8]
       test      edi,edi
       jle       short M01_L02
       cmp       [rbx],bl
       lea       rbp,[rdx+10]
M01_L00:
       mov       rdx,[rbp]
       mov       rcx,rbx
       call      qword ptr [7FFD93C6EE80]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       inc       esi
M01_L01:
       add       rbp,8
       dec       edi
       jne       short M01_L00
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 65
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L09
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L07
       mov       rdi,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        near ptr M02_L04
M02_L00:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rbx+8]
       mov       edx,ebp
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M02_L10
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r14d,[rcx]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
M02_L01:
       mov       r12d,[r15+8]
       cmp       r12d,r14d
       jbe       near ptr M02_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r14,[r15+rcx*8+10]
       cmp       [r14+8],ebp
       jne       short M02_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+50]
       test      r11,r11
       je        short M02_L05
M02_L02:
       mov       rdx,[r14]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
       lea       rax,[r14+10]
M02_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rdx,offset System.Collections.Generic.ArraySortHelper`1[[BenchmarkDotNet.Reports.Measurement, BenchmarkDotNet]].get_Default()
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M02_L00
M02_L05:
       mov       rdx,7FFD93D05CA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M02_L02
M02_L06:
       mov       r14d,[r14+0C]
       inc       r13d
       cmp       r12d,r13d
       jae       near ptr M02_L01
       jmp       short M02_L08
M02_L07:
       xor       eax,eax
       jmp       short M02_L03
M02_L08:
       call      qword ptr [7FFD938BF390]
       int       3
M02_L09:
       mov       ecx,4
       call      qword ptr [7FFD938BFC18]
       int       3
M02_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 322
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFDF2A6FBB8]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,rdx
       xor       edi,edi
       xor       ebp,ebp
       jmp       short M01_L07
M01_L00:
       mov       rdx,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[r9]
       xor       rdx,r8
       xor       rcx,[r9+2]
       or        rcx,rdx
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
M01_L01:
       mov       ecx,eax
       jmp       short M01_L04
M01_L02:
       xor       ecx,ecx
       jmp       short M01_L04
M01_L03:
       mov       ecx,1
M01_L04:
       test      ecx,ecx
       je        near ptr M01_L13
M01_L05:
       add       r15,10
       test      r15,r15
       je        short M01_L06
       inc       edi
M01_L06:
       inc       ebp
M01_L07:
       cmp       [rsi+8],ebp
       jle       near ptr M01_L22
       mov       r14,[rsi+rbp*8+10]
       cmp       [rbx],bl
       test      r14,r14
       je        near ptr M01_L25
       cmp       qword ptr [rbx+8],0
       je        short M01_L06
       mov       r15,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L23
       lea       rcx,[r14+0C]
       mov       [rsp+28],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rsp+28]
       mov       eax,[r14+8]
       cmp       eax,2
       jle       short M01_L09
M01_L08:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[r11]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[r11+4]
       add       r11,8
       cmp       eax,2
       jg        short M01_L08
M01_L09:
       test      eax,eax
       jle       short M01_L10
       mov       eax,edx
       rol       eax,5
       add       eax,edx
       mov       edx,eax
       xor       edx,[r11]
M01_L10:
       imul      r13d,edx,5D588B65
       add       r13d,ecx
       xor       ecx,ecx
       mov       [rsp+28],rcx
M01_L11:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       eax,r8d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M01_L26
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r12d,[rcx]
       mov       rax,[rbx+10]
       mov       [rsp+20],rax
       xor       r10d,r10d
       mov       [rsp+34],r10d
       dec       r12d
       cmp       [rax+8],r12d
       jbe       near ptr M01_L06
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L20
M01_L12:
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[rax+rcx*8+10]
       cmp       [r15+8],r13d
       jne       short M01_L13
       mov       rdx,[r15]
       cmp       rdx,r14
       je        near ptr M01_L03
       test      rdx,rdx
       je        near ptr M01_L02
       mov       ecx,[rdx+8]
       cmp       ecx,[r14+8]
       jne       near ptr M01_L02
       lea       rcx,[rdx+0C]
       lea       r9,[r14+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       je        near ptr M01_L00
       mov       rdx,r9
       call      qword ptr [7FFDF269C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L01
M01_L13:
       mov       r12d,[r15+0C]
       mov       r10d,[rsp+34]
       inc       r10d
       mov       rax,[rsp+20]
       mov       [rsp+34],r10d
       cmp       [rax+8],r10d
       jb        near ptr M01_L21
       cmp       [rax+8],r12d
       jbe       near ptr M01_L06
       jmp       near ptr M01_L12
M01_L14:
       mov       r8,r9
       mov       rdx,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[r8]
       xor       rdx,r11
       xor       rcx,[r8+2]
       or        rcx,rdx
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
M01_L15:
       mov       ecx,eax
       jmp       short M01_L18
M01_L16:
       xor       ecx,ecx
       jmp       short M01_L18
M01_L17:
       mov       ecx,1
M01_L18:
       test      ecx,ecx
       je        short M01_L19
       mov       r15,r12
       jmp       near ptr M01_L05
M01_L19:
       mov       r12d,[r12+0C]
       mov       r10d,[rsp+34]
       inc       r10d
       mov       rax,[rsp+20]
       cmp       [rax+8],r10d
       jb        short M01_L21
       cmp       [rax+8],r12d
       mov       [rsp+34],r10d
       jbe       near ptr M01_L06
M01_L20:
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rax+rcx*8+10]
       mov       r12,rcx
       cmp       [r12+8],r13d
       jne       short M01_L19
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       short M01_L24
       cmp       rdx,r14
       je        short M01_L17
       test      rdx,rdx
       je        short M01_L16
       mov       ecx,[rdx+8]
       cmp       ecx,[r14+8]
       jne       short M01_L16
       lea       rcx,[rdx+0C]
       lea       r9,[r14+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       je        near ptr M01_L14
       mov       rdx,r9
       call      qword ptr [7FFDF269C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L15
M01_L21:
       call      qword ptr [7FFDF269F480]
       int       3
M01_L22:
       mov       eax,edi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L23:
       mov       rcx,r15
       mov       rdx,r14
       mov       r11,7FFDF25E04C0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L11
M01_L24:
       mov       rcx,r15
       mov       r8,r14
       mov       r11,7FFDF25E04C8
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M01_L18
M01_L25:
       mov       ecx,4
       call      qword ptr [7FFDF269FD38]
       int       3
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 790
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFDC8DC7E28]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M01_L02
       cmp       [rsi],sil
M01_L00:
       mov       ecx,ebp
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,rsi
       call      qword ptr [7FFDC8C5E9E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       jne       short M01_L03
M01_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M01_L00
M01_L02:
       mov       eax,edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       inc       edi
       jmp       short M01_L01
; Total bytes of code 77
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L08
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L07
       mov       rdi,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+40]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFDC8E5E2D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L01:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rbx+8]
       mov       edx,ebp
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M02_L10
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
M02_L02:
       mov       r12d,[r15+8]
       cmp       r12d,r14d
       jbe       short M02_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r14,[r15+rcx*8+10]
       cmp       [r14+8],ebp
       jne       short M02_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFDC8E5E2E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L04:
       mov       rdx,[r14]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
       lea       rax,[r14+10]
M02_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       r14d,[r14+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        short M02_L09
       jmp       short M02_L02
M02_L07:
       xor       eax,eax
       jmp       short M02_L05
M02_L08:
       mov       ecx,4
       call      qword ptr [7FFDC8BFED00]
       int       3
M02_L09:
       call      qword ptr [7FFDC8BFF030]
       int       3
M02_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 304
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFD93C6EE38]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       mov       edi,[rdx+8]
       test      edi,edi
       jle       short M01_L02
       cmp       [rbx],bl
       lea       rbp,[rdx+10]
M01_L00:
       mov       rdx,[rbp]
       mov       rcx,rbx
       call      qword ptr [7FFD93C6EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       inc       esi
M01_L01:
       add       rbp,8
       dec       edi
       jne       short M01_L00
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 65
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L09
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L07
       mov       rdi,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        near ptr M02_L04
M02_L00:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rbx+8]
       mov       edx,ebp
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M02_L10
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r14d,[rcx]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
M02_L01:
       mov       r12d,[r15+8]
       cmp       r12d,r14d
       jbe       near ptr M02_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r14,[r15+rcx*8+10]
       cmp       [r14+8],ebp
       jne       short M02_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+50]
       test      r11,r11
       je        short M02_L05
M02_L02:
       mov       rdx,[r14]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
       lea       rax,[r14+10]
M02_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rdx,offset System.Collections.Generic.ArraySortHelper`1[[BenchmarkDotNet.Reports.Measurement, BenchmarkDotNet]]..cctor()
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M02_L00
M02_L05:
       mov       rdx,7FFD93D05CA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M02_L02
M02_L06:
       mov       r14d,[r14+0C]
       inc       r13d
       cmp       r12d,r13d
       jae       near ptr M02_L01
       jmp       short M02_L08
M02_L07:
       xor       eax,eax
       jmp       short M02_L03
M02_L08:
       call      qword ptr [7FFD938BF390]
       int       3
M02_L09:
       mov       ecx,4
       call      qword ptr [7FFD938BFC18]
       int       3
M02_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 322
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFDF2A3FBD0]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,rdx
       xor       edi,edi
       xor       ebp,ebp
       jmp       short M01_L07
M01_L00:
       mov       rdx,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[r9]
       xor       rdx,r8
       xor       rcx,[r9+2]
       or        rcx,rdx
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
M01_L01:
       mov       ecx,eax
       jmp       short M01_L04
M01_L02:
       xor       ecx,ecx
       jmp       short M01_L04
M01_L03:
       mov       ecx,1
M01_L04:
       test      ecx,ecx
       je        near ptr M01_L13
M01_L05:
       add       r15,10
       test      r15,r15
       je        short M01_L06
       inc       edi
M01_L06:
       inc       ebp
M01_L07:
       cmp       [rsi+8],ebp
       jle       near ptr M01_L22
       mov       r14,[rsi+rbp*8+10]
       cmp       [rbx],bl
       test      r14,r14
       je        near ptr M01_L25
       cmp       qword ptr [rbx+8],0
       je        short M01_L06
       mov       r15,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L23
       lea       rcx,[r14+0C]
       mov       [rsp+28],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rsp+28]
       mov       eax,[r14+8]
       cmp       eax,2
       jle       short M01_L09
M01_L08:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[r11]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[r11+4]
       add       r11,8
       cmp       eax,2
       jg        short M01_L08
M01_L09:
       test      eax,eax
       jle       short M01_L10
       mov       eax,edx
       rol       eax,5
       add       eax,edx
       mov       edx,eax
       xor       edx,[r11]
M01_L10:
       imul      r13d,edx,5D588B65
       add       r13d,ecx
       xor       ecx,ecx
       mov       [rsp+28],rcx
M01_L11:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       eax,r8d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M01_L26
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r12d,[rcx]
       mov       rax,[rbx+10]
       mov       [rsp+20],rax
       xor       r10d,r10d
       mov       [rsp+34],r10d
       dec       r12d
       cmp       [rax+8],r12d
       jbe       near ptr M01_L06
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L20
M01_L12:
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[rax+rcx*8+10]
       cmp       [r15+8],r13d
       jne       short M01_L13
       mov       rdx,[r15]
       cmp       rdx,r14
       je        near ptr M01_L03
       test      rdx,rdx
       je        near ptr M01_L02
       mov       ecx,[rdx+8]
       cmp       ecx,[r14+8]
       jne       near ptr M01_L02
       lea       rcx,[rdx+0C]
       lea       r9,[r14+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       je        near ptr M01_L00
       mov       rdx,r9
       call      qword ptr [7FFDF266C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L01
M01_L13:
       mov       r12d,[r15+0C]
       mov       r10d,[rsp+34]
       inc       r10d
       mov       rax,[rsp+20]
       mov       [rsp+34],r10d
       cmp       [rax+8],r10d
       jb        near ptr M01_L21
       cmp       [rax+8],r12d
       jbe       near ptr M01_L06
       jmp       near ptr M01_L12
M01_L14:
       mov       r8,r9
       mov       rdx,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[r8]
       xor       rdx,r11
       xor       rcx,[r8+2]
       or        rcx,rdx
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
M01_L15:
       mov       ecx,eax
       jmp       short M01_L18
M01_L16:
       xor       ecx,ecx
       jmp       short M01_L18
M01_L17:
       mov       ecx,1
M01_L18:
       test      ecx,ecx
       je        short M01_L19
       mov       r15,r12
       jmp       near ptr M01_L05
M01_L19:
       mov       r12d,[r12+0C]
       mov       r10d,[rsp+34]
       inc       r10d
       mov       rax,[rsp+20]
       cmp       [rax+8],r10d
       jb        short M01_L21
       cmp       [rax+8],r12d
       mov       [rsp+34],r10d
       jbe       near ptr M01_L06
M01_L20:
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rax+rcx*8+10]
       mov       r12,rcx
       cmp       [r12+8],r13d
       jne       short M01_L19
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       short M01_L24
       cmp       rdx,r14
       je        short M01_L17
       test      rdx,rdx
       je        short M01_L16
       mov       ecx,[rdx+8]
       cmp       ecx,[r14+8]
       jne       short M01_L16
       lea       rcx,[rdx+0C]
       lea       r9,[r14+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       je        near ptr M01_L14
       mov       rdx,r9
       call      qword ptr [7FFDF266C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L15
M01_L21:
       call      qword ptr [7FFDF266F480]
       int       3
M01_L22:
       mov       eax,edi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L23:
       mov       rcx,r15
       mov       rdx,r14
       mov       r11,7FFDF25B04C0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L11
M01_L24:
       mov       rcx,r15
       mov       r8,r14
       mov       r11,7FFDF25B04C8
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M01_L18
M01_L25:
       mov       ecx,4
       call      qword ptr [7FFDF266FD38]
       int       3
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 790
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFDC8DC7E28]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M01_L02
       cmp       [rsi],sil
M01_L00:
       mov       ecx,ebp
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,rsi
       call      qword ptr [7FFDC8C5E9E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       inc       edi
M01_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M01_L00
M01_L02:
       mov       eax,edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 75
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L08
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L07
       mov       rdi,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+40]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFDC8E5E2D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L01:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rbx+8]
       mov       edx,ebp
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M02_L10
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
M02_L02:
       mov       r12d,[r15+8]
       cmp       r12d,r14d
       jbe       short M02_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r14,[r15+rcx*8+10]
       cmp       [r14+8],ebp
       jne       short M02_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFDC8E5E2E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L04:
       mov       rdx,[r14]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
       lea       rax,[r14+10]
M02_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       r14d,[r14+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        short M02_L09
       jmp       short M02_L02
M02_L07:
       xor       eax,eax
       jmp       short M02_L05
M02_L08:
       mov       ecx,4
       call      qword ptr [7FFDC8BFED00]
       int       3
M02_L09:
       call      qword ptr [7FFDC8BFF030]
       int       3
M02_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 304
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFD93C9EE50]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       mov       edi,[rdx+8]
       test      edi,edi
       jle       short M01_L02
       cmp       [rbx],bl
       lea       rbp,[rdx+10]
M01_L00:
       mov       rdx,[rbp]
       mov       rcx,rbx
       call      qword ptr [7FFD93C9EE80]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       inc       esi
M01_L01:
       add       rbp,8
       dec       edi
       jne       short M01_L00
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 65
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L09
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L07
       mov       rdi,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        near ptr M02_L04
M02_L00:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rbx+8]
       mov       edx,ebp
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M02_L10
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r14d,[rcx]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
M02_L01:
       mov       r12d,[r15+8]
       cmp       r12d,r14d
       jbe       near ptr M02_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r14,[r15+rcx*8+10]
       cmp       [r14+8],ebp
       jne       short M02_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+50]
       test      r11,r11
       je        short M02_L05
M02_L02:
       mov       rdx,[r14]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
       lea       rax,[r14+10]
M02_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rdx,7FFD93D35C90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M02_L00
M02_L05:
       mov       rdx,7FFD93D35CA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M02_L02
M02_L06:
       mov       r14d,[r14+0C]
       inc       r13d
       cmp       r12d,r13d
       jae       near ptr M02_L01
       jmp       short M02_L08
M02_L07:
       xor       eax,eax
       jmp       short M02_L03
M02_L08:
       call      qword ptr [7FFD938EF390]
       int       3
M02_L09:
       mov       ecx,4
       call      qword ptr [7FFD938EFC18]
       int       3
M02_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 322
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v4 (Job: net10(Toolchain=net10))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFDF2A5FBD0]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,rdx
       xor       edi,edi
       xor       ebp,ebp
       jmp       short M01_L04
M01_L00:
       mov       ecx,1
M01_L01:
       test      ecx,ecx
       je        near ptr M01_L13
M01_L02:
       add       r15,10
       test      r15,r15
       je        short M01_L03
       inc       edi
M01_L03:
       inc       ebp
M01_L04:
       cmp       [rsi+8],ebp
       jle       near ptr M01_L22
       mov       r14,[rsi+rbp*8+10]
       cmp       [rbx],bl
       test      r14,r14
       je        near ptr M01_L25
       cmp       qword ptr [rbx+8],0
       je        short M01_L03
       mov       r15,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L23
       lea       rcx,[r14+0C]
       mov       [rsp+38],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rsp+38]
       mov       eax,[r14+8]
       cmp       eax,2
       jle       short M01_L06
M01_L05:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[r11]
       mov       r8d,edx
       rol       r8d,5
       add       edx,r8d
       xor       edx,[r11+4]
       add       r11,8
       cmp       eax,2
       jg        short M01_L05
M01_L06:
       test      eax,eax
       jle       short M01_L07
       mov       eax,edx
       rol       eax,5
       add       eax,edx
       mov       edx,eax
       xor       edx,[r11]
M01_L07:
       imul      r13d,edx,5D588B65
       add       r13d,ecx
       xor       ecx,ecx
       mov       [rsp+38],rcx
M01_L08:
       mov       rcx,[rbx+8]
       mov       edx,r13d
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       mov       eax,r8d
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,r8d
       jae       near ptr M01_L26
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r12d,[rcx]
       mov       rax,[rbx+10]
       mov       [rsp+28],rax
       xor       r10d,r10d
       mov       [rsp+44],r10d
       dec       r12d
       mov       r9d,[rax+8]
       mov       [rsp+34],r9d
       cmp       r9d,r12d
       jbe       near ptr M01_L03
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       near ptr M01_L20
M01_L09:
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       r15,[rax+rcx*8+10]
       cmp       [r15+8],r13d
       jne       short M01_L13
       mov       rdx,[r15]
       cmp       rdx,r14
       je        near ptr M01_L00
       test      rdx,rdx
       je        short M01_L12
       mov       ecx,[rdx+8]
       cmp       ecx,[r14+8]
       jne       short M01_L12
       lea       rcx,[rdx+0C]
       lea       r11,[r14+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       je        short M01_L10
       mov       rdx,r11
       call      qword ptr [7FFDF268C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L11
M01_L10:
       mov       rdx,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[r11]
       xor       rdx,r8
       xor       rcx,[r11+2]
       or        rcx,rdx
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
M01_L11:
       mov       ecx,eax
       jmp       near ptr M01_L01
M01_L12:
       xor       ecx,ecx
       jmp       near ptr M01_L01
M01_L13:
       mov       r12d,[r15+0C]
       mov       r10d,[rsp+44]
       inc       r10d
       mov       r9d,[rsp+34]
       mov       [rsp+44],r10d
       cmp       r9d,r10d
       jb        near ptr M01_L21
       cmp       r9d,r12d
       mov       rax,[rsp+28]
       jbe       near ptr M01_L03
       jmp       near ptr M01_L09
M01_L14:
       mov       r8,r11
       mov       rdx,[rcx]
       mov       rcx,[rcx+2]
       mov       r11,[r8]
       xor       rdx,r11
       xor       rcx,[r8+2]
       or        rcx,rdx
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
M01_L15:
       mov       ecx,eax
       jmp       short M01_L18
M01_L16:
       xor       ecx,ecx
       jmp       short M01_L18
M01_L17:
       mov       ecx,1
M01_L18:
       test      ecx,ecx
       je        short M01_L19
       mov       r15,r12
       jmp       near ptr M01_L02
M01_L19:
       mov       r12d,[r12+0C]
       mov       r10d,[rsp+44]
       inc       r10d
       mov       r9d,[rsp+34]
       cmp       r9d,r10d
       jb        short M01_L21
       cmp       r9d,r12d
       mov       [rsp+44],r10d
       mov       rax,[rsp+28]
       jbe       near ptr M01_L03
M01_L20:
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[rax+rcx*8+10]
       mov       r12,rcx
       cmp       [r12+8],r13d
       jne       short M01_L19
       mov       rdx,[r12]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r15],rcx
       jne       short M01_L24
       cmp       rdx,r14
       je        short M01_L17
       test      rdx,rdx
       je        short M01_L16
       mov       ecx,[rdx+8]
       cmp       ecx,[r14+8]
       jne       short M01_L16
       lea       rcx,[rdx+0C]
       lea       r11,[r14+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       cmp       r8,0A
       je        near ptr M01_L14
       mov       rdx,r11
       call      qword ptr [7FFDF268C330]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L15
M01_L21:
       call      qword ptr [7FFDF268F480]
       int       3
M01_L22:
       mov       eax,edi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L23:
       mov       rcx,r15
       mov       rdx,r14
       mov       r11,7FFDF25D04C0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L08
M01_L24:
       mov       rcx,r15
       mov       r8,r14
       mov       r11,7FFDF25D04C8
       call      qword ptr [r11]
       mov       ecx,eax
       jmp       near ptr M01_L18
M01_L25:
       mov       ecx,4
       call      qword ptr [7FFDF268FD38]
       int       3
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 795
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M02_L06
       cmp       rcx,rdx
       je        short M02_L04
       cmp       r8,10
       jae       short M02_L01
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
M02_L00:
       ret
M02_L01:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M02_L03
       movups    xmm0,[rcx]
       movups    xmm1,[rdx]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
M02_L02:
       add       rax,10
       cmp       r8,rax
       ja        short M02_L10
M02_L03:
       movups    xmm0,[rcx+r8]
       movups    xmm1,[rdx+r8]
       pcmpeqb   xmm0,xmm1
       pmovmskb  eax,xmm0
       cmp       eax,0FFFF
       jne       short M02_L05
M02_L04:
       mov       eax,1
       ret
M02_L05:
       xor       eax,eax
       ret
M02_L06:
       cmp       r8,4
       jb        short M02_L07
       add       r8,0FFFFFFFFFFFFFFFC
       mov       eax,[rcx]
       sub       eax,[rdx]
       mov       ecx,[rcx+r8]
       sub       ecx,[rdx+r8]
       or        eax,ecx
       sete      al
       movzx     eax,al
       jmp       short M02_L00
M02_L07:
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M02_L08
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M02_L08:
       test      r8b,1
       je        short M02_L09
       movzx     ecx,byte ptr [rcx+r10]
       movzx     edx,byte ptr [rdx+r10]
       sub       ecx,edx
       or        eax,ecx
M02_L09:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L00
M02_L10:
       movups    xmm0,[rcx+rax]
       movups    xmm1,[rdx+rax]
       pcmpeqb   xmm0,xmm1
       pmovmskb  r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M02_L05
       jmp       near ptr M02_L02
; Total bytes of code 237
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v4 (Job: net8(Toolchain=net8))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFDC8DD7E28]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M01_L02
       cmp       [rsi],sil
M01_L00:
       mov       ecx,ebp
       mov       rdx,[rbx+rcx*8+10]
       mov       rcx,rsi
       call      qword ptr [7FFDC8C6E9E8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       inc       edi
M01_L01:
       inc       ebp
       cmp       r14d,ebp
       jg        short M01_L00
M01_L02:
       mov       eax,edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 75
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L08
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L07
       mov       rdi,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+40]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFDC8E6E2D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L01:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rbx+8]
       mov       edx,ebp
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M02_L10
       mov       edx,edx
       mov       r14d,[rcx+rdx*4+10]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
M02_L02:
       mov       r12d,[r15+8]
       cmp       r12d,r14d
       jbe       short M02_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r14,[r15+rcx*8+10]
       cmp       [r14+8],ebp
       jne       short M02_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFDC8E6E2E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M02_L04:
       mov       rdx,[r14]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
       lea       rax,[r14+10]
M02_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L06:
       mov       r14d,[r14+0C]
       inc       r13d
       cmp       r12d,r13d
       jb        short M02_L09
       jmp       short M02_L02
M02_L07:
       xor       eax,eax
       jmp       short M02_L05
M02_L08:
       mov       ecx,4
       call      qword ptr [7FFDC8C0ED00]
       int       3
M02_L09:
       call      qword ptr [7FFDC8C0F030]
       int       3
M02_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 304
```

## .NET 9.0.4 (9.0.4, 9.0.425.16305), X64 RyuJIT x86-64-v4 (Job: net9(Toolchain=net9))

```assembly
; DictResizeProof.Benchmarks.CollisionBench.Lookup()
       mov       rdx,rcx
       mov       rcx,[rdx+8]
       mov       rdx,[rdx+10]
       jmp       qword ptr [7FFD93C7ED78]; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
; Total bytes of code 17
```
```assembly
; DictResizeProof.Subjects.Lookup(System.Collections.Generic.Dictionary`2<System.String,Int32>, System.String[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       xor       esi,esi
       mov       edi,[rdx+8]
       test      edi,edi
       jle       short M01_L02
       cmp       [rbx],bl
       lea       rbp,[rdx+10]
M01_L00:
       mov       rdx,[rbp]
       mov       rcx,rbx
       call      qword ptr [7FFD93C7EDA8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       inc       esi
M01_L01:
       add       rbp,8
       dec       edi
       jne       short M01_L00
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 65
```
```assembly
; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]].FindValue(System.__Canon)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M02_L09
       cmp       qword ptr [rbx+8],0
       je        near ptr M02_L07
       mov       rdi,[rbx+18]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+48]
       test      r11,r11
       je        near ptr M02_L04
M02_L00:
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       ebp,eax
       mov       rcx,[rbx+8]
       mov       edx,ebp
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M02_L10
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r14d,[rcx]
       mov       r15,[rbx+10]
       xor       r13d,r13d
       dec       r14d
M02_L01:
       mov       r12d,[r15+8]
       cmp       r12d,r14d
       jbe       near ptr M02_L07
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r14,[r15+rcx*8+10]
       cmp       [r14+8],ebp
       jne       short M02_L06
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+50]
       test      r11,r11
       je        short M02_L05
M02_L02:
       mov       rdx,[r14]
       mov       rcx,rdi
       mov       r8,rsi
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
       lea       rax,[r14+10]
M02_L03:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rdx,7FFD93D15C58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       near ptr M02_L00
M02_L05:
       mov       rdx,7FFD93D15C70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
       jmp       short M02_L02
M02_L06:
       mov       r14d,[r14+0C]
       inc       r13d
       cmp       r12d,r13d
       jae       near ptr M02_L01
       jmp       short M02_L08
M02_L07:
       xor       eax,eax
       jmp       short M02_L03
M02_L08:
       call      qword ptr [7FFD938CF390]
       int       3
M02_L09:
       mov       ecx,4
       call      qword ptr [7FFD938CFC18]
       int       3
M02_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 322
```

