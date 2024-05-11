#include <reg52.h>
#include <intrins.h>
#include"i2c.h"
#define uchar unsigned char
#define uint unsigned int
#define GPIO_KEY P1
sbit melody = P2^5;

sbit LSA = P2^2;
sbit LSB = P2^3;
sbit LSC = P2^4;
sbit BTN = P3^2;
sbit temp= P3^5;
bit btnPressed = 0;
//bit playMelodyEnabled = 0;
unsigned char eepromAddr = 0;
void At24c02Write(unsigned char ,unsigned char );
unsigned char At24c02Read(unsigned char );
#define Segment P0

int check=0;
uchar flag = 0;
uchar revData,play=1;
uchar buffer1,buffer2;
uchar updateConstRevData = 1;

#define P		0
#define C3	61714
#define Db3	61928
#define D3	62176
#define Eb3	62322
#define E3	62502
#define F3	62672
#define Gb3	62833
#define G3	62985
#define Ab3	63128
#define A3	63263
#define Bb3	63391
#define B3	63511
#define C4	63625
#define Db4	63731
#define D4	63835
#define Eb4	63928
#define E4	64021
#define F4	64103
#define Gb4	64185
#define G4	64260
#define Ab4	64331
#define A4	64400
#define Bb4	64463
#define B4	64524
#define C5	64580
#define Db5	64634
#define D5	64685
#define Eb5	64732
#define E5	64778
#define F5	64820
#define Gb5	64860
#define G5	64898
#define Ab5	64934
#define A5	64968
#define Bb5	65000
#define B5	65030
#define C6	65058
#define Db6	65085
#define D6	65110
#define Eb6	65134
#define E6	65157
#define F6	65178
#define Gb6	65198
#define G6	65217
#define Ab6	65235
#define A6	65252
#define Bb6	65268
#define B6	65283
#define C7	65297
#define Db7	65311
#define D7	65323
#define Eb7	65335
#define E7	65346
#define F7	65357
#define Gb7	65367
#define G7	65377
#define Ab7	65386
#define A7	65394
#define Bb7	65402
#define B7	65409

#define MelodyPin	melody

int seg_7, dich, tg;

unsigned char Bai1[8] = {0x00, 0x6f, 0x37, 0x06, 0x66, 0x77, 0x38, 0x73};
//unsigned char Bai2[8] = {0x00, 0x00, 0x00, 0x5b, 0x00, 0x30, 0x77, 0x7c};
unsigned char Bai2[8] = {0x00, 0x00, 0x00, 0x3f, 0x31, 0x73, 0x79, 0x79};
unsigned char Bai[8];
int dieukhien[8];

unsigned int qtrN, qtrN_us, wholeN, wholeN_us, halfN, halfN_us, eighthN, eighthN_us,
			 sixteenN, sixteenN_us, thirtyTwoN, thirtyTwoN_us, sixtyFourN, sixtyFourN_us,
			 sixN, sixN_us, twelveN, twelveN_us, twentyFourN, twentyFourN_us;

void Delay10MC(unsigned char);
void DigDisplay(void);

void T2ISR(void) interrupt 5 {
	MelodyPin = ~MelodyPin;
	TF2 = 0;
}

void MelodyTempo(int Tempo){
	qtrN = ((60000/Tempo));
	wholeN = qtrN*4;
	halfN = (qtrN*2);
	eighthN = (qtrN/2);
	sixteenN = (qtrN/4);
	thirtyTwoN = (qtrN/8);
	sixtyFourN = (qtrN/16);
	sixN = (wholeN/6);
	twelveN = (wholeN/12);
	twentyFourN = (wholeN/24);
}

void PlayNote(const unsigned char PitchH, const unsigned char PitchL){
	RCAP2H = PitchH;
	RCAP2L = PitchL;
	TH2 = PitchH;
	TL2 = PitchL;
	TF2 = 0;
	TR2 = 1;
	ET2 = 1;
	EA = 1;
}

void EndNote(void){
	EA = 0;
	TR2 = 0;
	TF2 = 0;
	MelodyPin = 1;
}

void delay_ms(unsigned int ms){
	for(;ms>0;ms--)
		{
			DigDisplay();}
		}
void Delay10ms(void)   //Îó²î 0us
{
    unsigned char a,b,c;
    for(c=1;c>0;c--)
        for(b=38;b>0;b--)
            for(a=130;a>0;a--);
}
void Melodyplay(const int Pitch, unsigned int interval){
	if(Pitch!=0)
		PlayNote(Pitch >> 8, Pitch);
	delay_ms(interval);
	EndNote();
}
void initUART(void) {
    TMOD = 0x20;  // Timer 1, mode 2
    TH1 = 0xFD;   // Baud rate 9600
    TR1 = 1;      // B?t d?u Timer 1
    SCON = 0x50;  // UART mode 1, 8-bit data, 1 stop bit, 1 start bit
    EA = 1;       // Cho phép ng?t toàn c?c
    ES = 1;       // Cho phép ng?t UART
}
void serial_Send (unsigned char x)
{
	SBUF = x;	//nap gia tri vao s=SUBF
	while (TI==0);	 //doi den khi data duoc gui hoan tat
	TI=0;	 //clear co TI ve 0 de thuc hien lan gui tiep theo	
}

void DigDisplay(void)
{
	unsigned char i;
	unsigned int j;
	for(i=0;i<8;i++)
	{
		switch(i)	 //Î»Ñ¡£¬Ñ¡ÔñµãÁÁµÄÊýÂë¹Ü£¬
		{
			case(0):
				LSA=0;LSB=0;LSC=0; break;//ÏÔÊ¾µÚ0Î»
			case(1):
				LSA=1;LSB=0;LSC=0; break;//ÏÔÊ¾µÚ1Î»
			case(2):
				LSA=0;LSB=1;LSC=0; break;//ÏÔÊ¾µÚ2Î»
			case(3):
				LSA=1;LSB=1;LSC=0; break;//ÏÔÊ¾µÚ3Î»
			case(4):
				LSA=0;LSB=0;LSC=1; break;//ÏÔÊ¾µÚ4Î»
			case(5):
				LSA=1;LSB=0;LSC=1; break;//ÏÔÊ¾µÚ5Î»
			case(6):
				LSA=0;LSB=1;LSC=1; break;//ÏÔÊ¾µÚ6Î»
			case(7):
				LSA=1;LSB=1;LSC=1; break;//ÏÔÊ¾µÚ7Î»	
		}
		Segment=Bai[i];
		//·¢ËÍ¶ÎÂë
		j=7;						 //É¨Ãè¼ä¸ôÊ±¼äÉè¶¨
		while(j--);	
		Segment = 0x00;//ÏûÒþ
	}
}

void serial_ISR(void) interrupt 4 {

    if (RI){
			revData = SBUF;
			
	   if (check==0) {  buffer1=SBUF; check=1;}
		else if(check == 1)  {  buffer2=SBUF; check=0; flag=1;}
			RI = 0;
       	
        }
    }
void playReceivedNote(uchar note, uchar duration) {
    uint pitch = P; // m?c d?nh là không có âm thanh
	uint dura;
    switch(note) {
			case 1: pitch = C3; break;	
			case 2: pitch = Db3; break;	
			case 3: pitch = D3; break;
			case 4: pitch = Eb3; break;	
			case 5: pitch = E3; break;	
			case 6: pitch = F3; break;
			case 7: pitch = Gb3; break;
			case 8: pitch = G3; break;	
			case 9: pitch = Ab3; break;	
			case 10: pitch = A3; break;
			case 11: pitch = Bb3; break;
			case 12: pitch = B3; break;
			case 13: pitch = C4; break;	
			case 14: pitch = Db4; break;	
			case 15: pitch = D4; break;
			case 16: pitch = Eb4; break;	
			case 17: pitch = E4; break;	
			case 18: pitch = F4; break;
			case 19: pitch = Gb4; break;
			case 20: pitch = G4; break;	
			case 21: pitch = Ab4; break;	
			case 22: pitch = A4; break;
			case 23: pitch = Bb4; break;
			case 24: pitch = B4; break;
			case 25: pitch = C5; break;
			case 26: pitch = Db5; break;
			case 27: pitch = D5; break;
			case 28: pitch = Eb5; break;
			case 29: pitch = E5; break;
			case 30: pitch = F5; break;
			case 31: pitch = Gb5 ; break;
			case 32: pitch = G5	; break;
			case 33: pitch = Ab5 ; break;
			case 34: pitch = A5	; break;
			case 35: pitch = Bb5 ; break;
			case 36: pitch = B5 ; break;
			case 37: pitch = C6; break;
			case 38: pitch = Db6; break;
			case 39: pitch = D6; break;
			case 40: pitch = Eb6; break;
			case 41: pitch = E6; break;
			case 42: pitch = F6; break;
			case 43: pitch = Gb6 ; break;
			case 44: pitch = G6	; break;
			case 45: pitch = Ab6 ; break;
			case 46: pitch = A6	; break;
			case 47: pitch = Bb6 ; break;
			case 48: pitch = B6 ; break;
			case 49: pitch = C7; break;
			case 50: pitch = Db7; break;
			case 51: pitch = D7; break;
			case 52: pitch = Eb7; break;
			case 53: pitch = E7; break;
			case 54: pitch = F7; break;
			case 55: pitch = Gb7 ; break;
			case 56: pitch = G7	; break;
			case 57: pitch = Ab7 ; break;
			case 58: pitch = A7	; break;
			case 59: pitch = Bb7 ; break;
			case 60: pitch = B7 ; break;

      default: pitch = P; 
    }
	MelodyTempo(125);
	switch (duration)
            {
                case 1: dura=qtrN; break;
                case 2: dura=wholeN; break;
                case 3: dura= halfN; break;
                case 4: dura=eighthN; break;
                case 5: dura=sixteenN; break;
                case 6: dura=thirtyTwoN; break;
                case 7: dura=sixtyFourN; break;
                case 8: dura=sixN; break;
                case 9: dura=twelveN; break;
                case 10: dura=twentyFourN; break;
                default: dura=0;
            }
     if (pitch != P) {
        Melodyplay(pitch,dura);
    }
		 
    delay_ms(duration);
    EndNote();
	//temp=!temp;
	}
void At24c02Write(unsigned char addr,unsigned char dat)
{
	I2cStart();
	I2cSendByte(0xa0);//·¢ËÍÐ´Æ÷¼þµØÖ·
	I2cSendByte(addr);//·¢ËÍÒªÐ´ÈëÄÚ´æµØÖ·
	I2cSendByte(dat);	//·¢ËÍÊý¾Ý
	I2cStop();

}

uchar At24c02Read(unsigned char addr)
{
	uchar num;
	I2cStart();
	I2cSendByte(0xa0); //·¢ËÍÐ´Æ÷¼þµØÖ·
	I2cSendByte(addr); //·¢ËÍÒª¶ÁÈ¡µÄµØÖ·
	I2cStart();
	I2cSendByte(0xa1); //·¢ËÍ¶ÁÆ÷¼þµØÖ·
	num=I2cReadByte(); //¶ÁÈ¡Êý¾Ý
	I2cStop();
	return num;	
}
void playMelodyFromEEPROM() {
    unsigned int addr = 0;
    unsigned char storedData1;
		unsigned char storedData2;
		uchar i;
		for (i = 0; i < 8; i++)
					{
							Bai[i] = Bai2[i];
						//	At24c02clear();
					}
    do {
				delay_ms(50);
        storedData1 = At24c02Read(addr);
			if (storedData1 == 0xff) {
				break;
			}
		addr++;
		storedData2 = At24c02Read(addr);
        playReceivedNote(storedData1, storedData2); 
		EA = 1;
        addr++;
        if (addr >255)
		{
        break; 
        }
    } while (play!=0);
	play=1;  
}
void  At24c02clear(){
	unsigned char Ad=0; 
	do {
	 At24c02Write(Ad, 0xff);
		delay_ms(10);
	 Ad++;
	}
	while  (Ad<255);
}
  
void KeyDown(void)
{
	char a=0;
	GPIO_KEY=0x0f;
	if(GPIO_KEY!=0x0f)//¶ÁÈ¡°´¼üÊÇ·ñ°´ÏÂ
	{
		Delay10ms();//ÑÓÊ±10ms½øÐÐÏû¶¶
		if(GPIO_KEY!=0x0f)//ÔÙ´Î¼ì²â¼üÅÌÊÇ·ñ°´ÏÂ
		{
			
			//²âÊÔÁÐ
			GPIO_KEY=0X0F;
			switch(GPIO_KEY)
			{
			//	case(0X07):KeyValue=0;break;
			//	case(0X0b):	KeyValue=1;break;
				case(0X0d): At24c02clear();	eepromAddr = 0; break;
				case(0X0e): playMelodyFromEEPROM();break;	 
			}	 
			while((a<50)&&(GPIO_KEY!=0xf0))	 //¼ì²â°´¼üËÉÊÖ¼ì²â
			{
				Delay10ms();
				a++;
			}
		}
	}  }	
void initINT(){
	EA = 1;     
    EX0 = 1;    
    IT0 = 1;    

    EX1 = 1;   
    IT1 = 1;    
}
void externalInterrupt0() interrupt 0
{
    play=!play ;
//	KeyDown();
	//serial_Send('0');
}

void externalInterrupt1() interrupt 2
{
	serial_Send('2');
    // X? lý khi có ng?t ngo?i INT1
} 

void main(){
	int i;

	P0 = 0x00;
	initINT();
 	initUART();
//	At24c02clear();
  	
	while(1)
	{	KeyDown();

		if(flag ==1)
			{
				if(revData == 0xff){  
						for (i = 0; i < 8; i++)
					{
							Bai[i] = Bai1[i];
						//	At24c02clear();
					}
				}
				if(revData == 0xfe){  
						for (i = 0; i < 8; i++)
					{
							Bai[i] = Bai1[i];
						//	At24c02clear();
					}
				}

				//ghi vao eeprom buffer1
				 At24c02Write(eepromAddr, buffer1);
				 delay_ms(10);
                 eepromAddr++;
                 if (eepromAddr > 255) eepromAddr = 0; 
				//ghi vao eeprom buffer2
                 At24c02Write(eepromAddr, buffer2);
				 delay_ms(10);
                 eepromAddr++;
                 if (eepromAddr > 255) eepromAddr = 0;   
                									   
				if (play==1)
				{
					playReceivedNote(buffer1,buffer2);

					EA = 1;
					flag=0;
					serial_Send('1');
				}	  
	   			  

			} 
	}
}	
