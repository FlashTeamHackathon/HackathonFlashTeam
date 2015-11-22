//
//  CadidateTableViewCell.h
//  PotentialCandidate
//
//  Created by Pham Quoc Bao on 11/21/15.
//  Copyright (c) 2015 pqb_lt. All rights reserved.
//

#import <UIKit/UIKit.h>
@class Candidate;
@interface CadidateTableViewCell : UITableViewCell
@property (nonatomic,strong) Candidate *candidate;
- (void)setupCell:(Candidate *)candidateItem;
@end
