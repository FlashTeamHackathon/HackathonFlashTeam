//
//  InterviewListViewController.m
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/22/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import "InterviewListViewController.h"
#import "CadidateData.h"
#import "TitleTable.h"
#import "CadidateTableViewCell.h"
#import "InterViewDetailsViewController.h"
@interface InterviewListViewController ()<InterViewDetailsViewControllerDelegate>
@property (weak, nonatomic) IBOutlet UITableView *tblCandidateList;
@property (nonatomic,strong) NSMutableArray *arrInterView;
@property (nonatomic,strong) NSMutableArray *arrInterViewed;
@end

@implementation InterviewListViewController

- (void)viewDidLoad {
    [super viewDidLoad];
           [self.tblCandidateList registerNib:[UINib nibWithNibName:@"CadidateTableViewCell" bundle:nil] forCellReuseIdentifier:@"CadidateTableViewCell"];
       [self.tblCandidateList registerNib:[UINib nibWithNibName:@"InterViewedTableViewCell" bundle:nil] forCellReuseIdentifier:@"InterViewedTableViewCell"];
    [self loadData];

    UINavigationController *navController =  self.splitViewController.viewControllers.lastObject;
    InterViewDetailsViewController *details = navController.viewControllers.firstObject;
    if (self.arrInterView.count >0 ) {
        details.candidateSeletedVaule = [self.arrInterView objectAtIndex:0];
     
    }
    details.delegate = self;
    
}
- (void)updateInterview:(Candidate *)candidate
{
    [self loadData];
}
-(void)viewWillAppear:(BOOL)animated
{
    [super viewWillAppear:animated];
    [self loadData];
}
- (void)loadData
{
    self.arrInterView = [[CadidateData shareInstance] arrInterView];
    self.arrInterViewed = [[CadidateData shareInstance] arrInterViewed];
    [self.tblCandidateList reloadData];
    
}
- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}
- (NSInteger)numberOfSectionsInTableView:(UITableView *)tableView
{
    return 2;
}
- (UIView *)tableView:(UITableView *)tableView viewForHeaderInSection:(NSInteger)section
{
    NSArray *nib = [[NSBundle mainBundle] loadNibNamed:@"TitleTable" owner:self options:nil];
    TitleTable *headerView = (TitleTable *)[nib objectAtIndex:0];
    switch (section) {
        case 0:
            headerView.lblTitle.text = @"Waiting Interview";
            break;
        case 1:
            headerView.lblTitle.text = @"Interviewed";
        default:
            break;
    }
    return headerView;
    
}
-(void)setArrInterView:(NSMutableArray *)arrInterView
{
    _arrInterView = arrInterView;
}
- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section
{
    switch (section) {
        case 0:
            return   [self.arrInterView count];
            break;
        case 1:
            return   [self.arrInterViewed count];
            break;
            
        default:
            break;
    }
    return 0;
}
-(UITableViewCell*)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath
{
    CadidateTableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:@"CadidateTableViewCell"];
    CadidateTableViewCell *cell1 = [tableView dequeueReusableCellWithIdentifier:@"InterViewedTableViewCell"];
    Candidate *candidateItem;
    if (indexPath.section == 0) {
        candidateItem = [self.arrInterView objectAtIndex:indexPath.row];
          [cell setupCell:candidateItem];
        return cell;
    }
    else
    {
        candidateItem = [self.arrInterViewed objectAtIndex:indexPath.row];
          [cell1 setupCell:candidateItem];
        return cell1;
        
    }
  
    return cell;
    
}
- (CGFloat)tableView:(UITableView *)tableView heightForRowAtIndexPath:(NSIndexPath *)indexPath
{
    if (indexPath.section == 1) {
        return 70;
    }
    return 60.0f;
}
- (CGFloat)tableView:(UITableView *)tableView heightForHeaderInSection:(NSInteger)section
{
    return 30.0f;
}
- (void)tableView:(UITableView *)tableView didSelectRowAtIndexPath:(NSIndexPath *)indexPath
{
    Candidate *candidateItem;
    switch (indexPath.section) {
        case 0:
            candidateItem = [self.arrInterView objectAtIndex:indexPath.row];;
            break;
        case 1:
            candidateItem = [self.arrInterViewed objectAtIndex:indexPath.row];
            break;
            
        default:
            break;
    }
    if (self.delegate && [self.delegate respondsToSelector:@selector(candidateSeleted:)]) {
        [self.delegate candidateSeleted:candidateItem];
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
