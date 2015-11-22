//
//  CadidatesViewController.m
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/21/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import "CadidatesViewController.h"
#import "CadidateTableViewCell.h"
#import "Candidate.h"
#import "CadidateData.h"
#import "TitleTable.h"
#import "DetailsViewController.h"
@interface CadidatesViewController ()<UITableViewDataSource,UITableViewDelegate>
@property (weak, nonatomic) IBOutlet UITableView *tblCandidate;


@end

@implementation CadidatesViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view.
       [self.tblCandidate registerNib:[UINib nibWithNibName:@"CadidateTableViewCell" bundle:nil] forCellReuseIdentifier:@"CadidateTableViewCell"];
    //dummy data
   
    [self loadData];
    UINavigationController *navController =  self.splitViewController.viewControllers.lastObject;
    DetailsViewController *details = navController.viewControllers.firstObject;
    if (self.arrApplied.count >0 ) {
        details.candidateSeletedVaule = [self.arrApplied objectAtIndex:0];
          [self tableView:self.tblCandidate didSelectRowAtIndexPath:[NSIndexPath indexPathForItem:0 inSection:0]];
    }
   
}
- (void)loadData
{
 
    self.arrApplied =  [[CadidateData shareInstance] arrApplied];
    self.arrPotential = [[CadidateData shareInstance] arrPotential];
    
 
    
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
            headerView.lblTitle.text = @"Applied Candidate";
            break;
         case 1:
             headerView.lblTitle.text = @"Potential Candidate";
        default:
            break;
    }
    return headerView;

}
- (NSInteger)tableView:(UITableView *)tableView numberOfRowsInSection:(NSInteger)section
{
    switch (section) {
        case 0:
          return   [self.arrApplied count];
            break;
        case 1:
           return   [self.arrPotential count];
            break;
            
        default:
            break;
    }
    return 0;
}
-(UITableViewCell*)tableView:(UITableView *)tableView cellForRowAtIndexPath:(NSIndexPath *)indexPath
{
  CadidateTableViewCell *cell = [tableView dequeueReusableCellWithIdentifier:@"CadidateTableViewCell"];
    Candidate *candidateItem;
    if (indexPath.section == 0) {
        candidateItem = [self.arrApplied objectAtIndex:indexPath.row];
        
    }
    else
    {
        candidateItem = [self.arrPotential objectAtIndex:indexPath.row];
        
    }
    [cell setupCell:candidateItem];
    return cell;
    
}
- (CGFloat)tableView:(UITableView *)tableView heightForRowAtIndexPath:(NSIndexPath *)indexPath
{
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
            candidateItem = [self.arrApplied objectAtIndex:indexPath.row];;
            break;
        case 1:
              candidateItem = [self.arrPotential objectAtIndex:indexPath.row];
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
