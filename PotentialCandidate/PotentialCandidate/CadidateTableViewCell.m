//
//  CadidateTableViewCell.m
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/21/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import "CadidateTableViewCell.h"
#import "Candidate.h"
@interface CadidateTableViewCell ()
{
    
}
@property (weak, nonatomic) IBOutlet UILabel *lblFullName;

@property (weak, nonatomic) IBOutlet UIImageView *imvAvartar;
@property (weak, nonatomic) IBOutlet UILabel *lblJobTitile;
@property (weak, nonatomic) IBOutlet UIView *uivScore;
@property (weak, nonatomic) IBOutlet UILabel *lblPerScore;

@end
@implementation CadidateTableViewCell

- (void)awakeFromNib {
    // Initialization code
}

- (void)setSelected:(BOOL)selected animated:(BOOL)animated {
    [super setSelected:selected animated:animated];

    // Configure the view for the selected state
}
- (void)setupCell:(Candidate *)candidateItem
{
    self.candidate = candidateItem;
    self.imvAvartar.image = [UIImage imageNamed:candidateItem.imageAvartar];
    self.lblFullName.text = candidateItem.fullName;
    self.lblJobTitile.text = candidateItem.jobTitle;
    self.lblPerScore.text = [NSString stringWithFormat:@"%ld %%",(long)candidateItem.score];
   
    
}
- (void)layoutSubviews
{
    [super layoutSubviews];
    float score = ((float)self.candidate.score / 170.0) *100;
  
  self.uivScore.frame = CGRectMake(106.0, 44.0, score, 8.0);
    
   
}
@end
