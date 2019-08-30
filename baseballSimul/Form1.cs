using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baseballSimul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int RedScore,BlueScore; //각 팀별 점수변수 지정
        int Count; // 안타횟수 
        
        private void Button1_Click(object sender, EventArgs e)
        {   
            if(BlueInput.Value < RedInput.Value)  // 블루팀 점수가 레드팀 점수보다 낮을경우 실행안되게 설정
            {
                MessageBox.Show("Red Team 점수보다 Blue Team 점수를 높게 설정해주세요."); 
            }
            else
            {
                BlueScore = Convert.ToInt32(BlueInput.Value); // 입력받은 BlueTeam 점수값 BlueScore 에 저장
                RedScore = Convert.ToInt32(RedInput.Value); // 입력받은 RedTeam 점수값 RedScore 에 저장


                while (BlueScore >= RedScore) // RedTeam 점수가 높을때까지 반복
                {
                    if (Count == 0) // 첫 타자가 안타칠경우
                    {
                        Count++;
                    }
                    else if (Count == 1) // 두번째 타자가 안타칠 경우
                    {
                        Count++;
                        RedScore += 1;
                    }
                    else // 세번째 타자부터 반복실행
                    {
                        for (int a = 0; a < 3; a++) // 3번째 부터 3점씩 추가되므로 for문 사용했습니다.
                        {
                            Count++;
                        }
                        RedScore += 3;
                    }
                }

                startBtn.Enabled = false; // 실행 누를 시 중복재생을 방지하기 위함
                MessageBox.Show("시뮬레이션 완료!!\n\n최소 안타수 : "+ Convert.ToString(Count)+"\n스코어 : BlueTeam( "
                    +BlueScore+" ) : RedTeam( "+RedScore+" )","실행결과"); // 결과를 메세지 창으로 확인
            }
        }

        

        private void Reset_Click(object sender, EventArgs e) // 초기화버튼 누를시 모든값 초기화
        {
            startBtn.Enabled = true; 
            BlueInput.Value = 0;
            RedInput.Value = 0;            
            Count = 0;
        }
    }
}
