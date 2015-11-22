//
//  InterViewDetailsViewController.m
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/22/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import "InterViewDetailsViewController.h"
#import "InterviewListViewController.h"
#import "CadidateData.h"
#import "Candidate.h"
@interface InterViewDetailsViewController ()<InterviewListViewControllerDelegate>
@property (weak, nonatomic) IBOutlet UIView *MainView;

@end

@implementation InterViewDetailsViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view.
    UINavigationController *navController =  self.splitViewController.viewControllers.firstObject;
    UIViewController *viewController  = navController.viewControllers.firstObject;
    if ([viewController isKindOfClass:[InterviewListViewController class]]) {
        InterviewListViewController *candiViewController = navController.viewControllers.firstObject;
        candiViewController.delegate = self;
        if(self.candidateSeletedVaule)
        {
            [self candidateSeleted:self.candidateSeletedVaule];
        }
        
    }
    
    [self.btnBookInterview setTitle:@"Save" forState:UIControlStateNormal];
}
- (void)viewWillAppear:(BOOL)animated
{
    if (self.candidateSeletedVaule) {
    
        [self candidateSeleted:self.candidateSeletedVaule];
        self.MainView.hidden = YES;
    }
    
    else
    {
        self.MainView.hidden = NO;
        
        
    }
}
- (void)candidateSeleted:(Candidate *)cadidate
{
    self.MainView.hidden = cadidate?YES:NO;
    
    [super candidateSeleted:cadidate];
    [self.siderScore setEnabled:false];
    [self.siderScoreActure setEnabled: true];
    [self.btnBookInterview setTitle:@"Save" forState:UIControlStateNormal];
    [self.btnBookInterview setEnabled:YES];
}
- (IBAction)bookPressed:(id)sender {
    float score = self.siderScoreActure.value *100 ;
    int result = (int)ceilf(score );
    [[CadidateData shareInstance] updateCadidateAffterInterView:result idCandidate:self.candidateSeletedVaule.idCandidate];
    if(self.delegate && [self.delegate respondsToSelector:@selector(updateInterview:)])
    {
        self.candidateSeletedVaule = [[CadidateData shareInstance] getCandidateWithID:self.candidateSeletedVaule.idCandidate];
        [self.delegate updateInterview:self.candidateSeletedVaule];
        [self candidateSeleted:self.candidateSeletedVaule];
    }
    
}
- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}
- (IBAction)scoreActualChangeValue:(id)sender {
    self.lblActualScore.text =[NSString stringWithFormat:@"%1.f %%", self.siderScoreActure.value * 100] ;
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
