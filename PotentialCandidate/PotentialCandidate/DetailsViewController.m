//
//  DetailsViewController.m
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/21/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import "DetailsViewController.h"
#import "CadidatesViewController.h"
#import "CadidateData.h"
@interface DetailsViewController ()<CadidatesViewControllerDelegate>



@end

@implementation DetailsViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view.
    UINavigationController *navController =  self.splitViewController.viewControllers.firstObject;
    UIViewController *viewController  = navController.viewControllers.firstObject;
    if ([viewController isKindOfClass:[CadidatesViewController class]]) {
        CadidatesViewController *candiViewController = navController.viewControllers.firstObject;
        candiViewController.delegate = self;
        if(self.candidateSeletedVaule)
        {
            [self candidateSeleted:self.candidateSeletedVaule];
        }

    }
}

- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}
- (IBAction)bookPressed:(id)sender {
    if (self.candidateSeletedVaule.isBookInterview) {
        UIAlertView *alertView = [[UIAlertView alloc] initWithTitle:@"Booked InterView" message:@"The Candidate has booked interview" delegate:self cancelButtonTitle:@"Cancel" otherButtonTitles: nil];
        [alertView show];
        return;
    }
    [[CadidateData shareInstance] updateCadidateIsBookInterview:YES idCandidate:self.candidateSeletedVaule.idCandidate];
    Candidate *candidate = [[CadidateData shareInstance] getCandidateWithID:self.candidateSeletedVaule.idCandidate];
    [self candidateSeleted:candidate];
}
- (IBAction)callPressed:(id)sender {
    UIAlertView *alert = [[UIAlertView alloc] initWithTitle:@"coming soon" message:@"Supree softfront/CallController library of Softfront VN" delegate:nil cancelButtonTitle:@"OK" otherButtonTitles: nil];
    [alert show];
}
- (void)candidateSeleted:(Candidate *)cadidate
{
    self.candidateSeletedVaule =cadidate;
    self.title = cadidate.fullName;
    self.imvAvartar.image = [UIImage imageNamed:cadidate.imageAvartar];
    self.lblFullName.text  = cadidate.fullName;
    self.lblPhoneNumber.text = cadidate.phoneNumber;
    self.lblAddress.text = cadidate.address;
    self.lblExpreience.text = [NSString stringWithFormat:@"%ld years",(long)cadidate.experience] ;
    self.lblMajor.text = cadidate.major;
    self.lblJobTitle.text = cadidate.jobTitle;
    self.lblSchool.text = cadidate.school;
    self.siderScore.value = (float)cadidate.score/100;
    self.siderScoreActure.value = (float)cadidate.actualScore/100;
    self.siderScore.enabled = false;
    self.siderScoreActure.enabled = false;
    self.lblScore.text = [NSString stringWithFormat:@"%ld%%",(long)cadidate.score];
     self.lblActualScore.text = [NSString stringWithFormat:@"%ld%%",(long)cadidate.actualScore];
    self.btnBookInterview.enabled  = !self.candidateSeletedVaule.isBookInterview;
    if (self.candidateSeletedVaule.isBookInterview) {
        [self.btnBookInterview setTitle:@"Booked Interview" forState:UIControlStateNormal];
    }
    else
    {
          [self.btnBookInterview setTitle:@"Book Interview" forState:UIControlStateNormal];
        
    }
   
    
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
