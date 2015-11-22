//
//  SettingViewController.m
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/22/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import "SettingViewController.h"

@interface SettingViewController ()
{
    
}
@property (weak, nonatomic) IBOutlet UISlider *sliderScore;
@property (weak, nonatomic) IBOutlet UISwitch *swScore;
@property (weak, nonatomic) IBOutlet UISlider *sliderExpre;
@property (weak, nonatomic) IBOutlet UISwitch *swExprerience;
@property (weak, nonatomic) IBOutlet UISlider *sliderAge;
@property (weak, nonatomic) IBOutlet UISwitch *swAge;
@property (weak, nonatomic) IBOutlet UISegmentedControl *sggraden;
@property (weak, nonatomic) IBOutlet UISwitch *swgraden;
@property (weak, nonatomic) IBOutlet UILabel *lblValueScore;
@property (weak, nonatomic) IBOutlet UILabel *lblAgeValue;
@property (weak, nonatomic) IBOutlet UILabel *lblExprenceValue;
@property (weak, nonatomic) IBOutlet UILabel *lblgadenValue;

@end

@implementation SettingViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view.
}
- (IBAction)swScoreChangePressed:(id)sender {
    self.sliderScore.enabled = self.swScore.on;
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}
- (IBAction)swExpreiencePresses:(id)sender {
    self.sliderExpre.enabled = self.swScore.on;
}
- (IBAction)swAgePressed:(id)sender {
       self.sliderAge.enabled = self.swAge.on;
}
- (IBAction)swGadenPresses:(id)sender {
       self.sggraden.enabled = self.swgraden.on;
}
- (IBAction)sliderScorePressed:(id)sender {
    NSString *value = [NSString stringWithFormat:@"%1.f %%",self.sliderScore.value];
    self.lblValueScore.text = value;
}
- (IBAction)sliderExprePressed:(id)sender {
    NSString *value = [NSString stringWithFormat:@"%1.f ",self.sliderExpre.value];
    self.lblExprenceValue.text = value;
}
- (IBAction)sliderOldPressed:(id)sender {
    NSString *value = [NSString stringWithFormat:@"%1.f",self.sliderAge.value];
    self.lblAgeValue.text = value;
}
- (IBAction)sgGradenpressed:(id)sender {
    
    NSInteger i =  self.sggraden.selectedSegmentIndex;
    NSString *gender = @"Male";
    if(i == 1 )
    {
        gender = @"Female";

    }
    self.lblgadenValue.text = gender;
}

/*
#pragma mark - Navigation

// In a storyboard-based application, you will often want to do a little preparation before navigation
- (void)prepareForSegue:(UIStoryboardSegue *)segue sender:(id)sender {
    // Get the new view controller using [segue destinationViewController].
    // Pass the selected object to the new view controller.
}
*/

@end
